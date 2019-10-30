using UnityEngine;
using UnityEngine.UI;

public class PlayerFigure : MonoBehaviour
{
    Vector3 moveVector;

    [SerializeField] [Tooltip("연료 수치")] float gasFigure = 1f;
    [SerializeField] [Tooltip("이동 속도")] float moveSpeed = 5f;

    // 부스터 사용하는가 ?
    public static bool isBoost = false;
    // 무적인가 ?
    public static bool isInvincibility = false;

    public Slider slider;

    // 소환한 오브젝트를 받아오는 변수
    GameObject[] obj;

    Transform oldTrans;

    int spotCount = 0;

    void Start()
    {
        moveVector = Vector3.zero;
    }

    void Update()
    {
        HandleInput();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isBoost = true;
            //isInvincibility = true;
        }

        if (gasFigure <= 0f)
        {
            moveVector = Vector3.zero;
            SceneMgr.LoadingScene(SceneMgr.Scene.GameOver);
            SoundMgr.Instance.StopBGM();
        }

        if (spotCount == 5)
        {
            BulletManager.Instance.isClear = true;
        }

        if (isHeal)
        {
        }
    }

    void FixedUpdate()
    {
        Move();

        if (transform.position.x >= 8.5f)
            transform.position = new Vector2(8.5f, transform.position.y);
        else if (transform.position.x <= -8.5f)
            transform.position = new Vector2(-8.5f, transform.position.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (isInvincibility)
            return;

        // Tag 확인
        // 데미지 입음
        if (other.tag == "Boss")
        {
            SoundMgr.Instance.PlaySfxSound("BossDamaged");

            gasFigure -= 1f; // 데미지로 교체

            EffectMgr.SliderValue(slider, gasFigure);
            StartCoroutine(EffectMgr.CameraShake(Camera.main.transform, 0.25f, 0.3f));

            Debug.Log(gasFigure);
        }
        // 데미지 줌
        else if (other.tag == "Spot")
        {
            SoundMgr.Instance.PlaySfxSound("BossDamaged");
            StartCoroutine(EffectMgr.CameraShake(Camera.main.transform, 0.25f, 0.3f));
            spotCount++;

            Debug.Log("Spot");
            other.gameObject.SetActive(false);
        }
        else if (other.name.Contains("Bullet"))
        {
            SoundMgr.Instance.PlaySfxSound("BulletDamaged", false, 0.1f);
            gasFigure -= 0.005f; // 데미지로 교체

            EffectMgr.SliderValue(slider, gasFigure);
            StartCoroutine(EffectMgr.CameraShake(Camera.main.transform, 0.10f, 0.15f));

            other.gameObject.SetActive(false);
            Debug.Log(gasFigure);
        }
    }

    public bool isHeal = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name.Contains("Floor"))
        {
            SoundMgr.Instance.PlaySfxSound("Heal");
            isHeal = true;
            gasFigure = gasFigure + 0.4f > 1f ? 1f : gasFigure + 0.4f;
            EffectMgr.SliderValue(slider, gasFigure);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Floor"))
        {
            isHeal = false;
        }
    }

    void HandleInput()
    {
        moveVector = TouchPed.inputVector.normalized;
    }

    void Move()
    {
        if (!isBoost)
        {
            transform.position += moveVector * moveSpeed * Time.deltaTime;
        }
        else
        {
            SoundMgr.Instance.PlaySfxSound("Boost");
            StartCoroutine(EffectMgr.CameraShake(Camera.main.transform, 0.25f, 0.3f));
            transform.position += moveVector * 2.5f;
            gasFigure -= 0.005f;
            EffectMgr.SliderValue(slider, gasFigure);
            isBoost = false;
        }
    }

    void SetInvincibility()
    {
        Debug.Log(isInvincibility);
        isInvincibility = !isInvincibility;
    }
}
