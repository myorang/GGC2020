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
            isInvincibility = true;
        }

        if (gasFigure <= 0f)
        {
            SceneMgr.LoadingScene(SceneMgr.Scene.GameOver);
        }

        if (spotCount == 5)
        {
            SceneMgr.LoadingScene(SceneMgr.Scene.Epilogue);
        }
    }

    void FixedUpdate()
    {
        if (transform.position.x >= 9f)
            transform.position = new Vector2(8f, 0f);
        else if (transform.position.x <= -9f)
            transform.position = new Vector2(-8f, 0f);

        Move();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Tag 확인
        // 데미지 입음
        if (other.tag == "Boss") 
        {
            if (isInvincibility)
            {
                Debug.Log("aaa00");
                return;
            }

             gasFigure -= 1f; // 데미지로 교체

            EffectMgr.SliderValue(slider, gasFigure);
            StartCoroutine(EffectMgr.CameraShake(Camera.main.transform, 0.25f, 0.3f));

            Debug.Log(gasFigure);
        }
        // 데미지 줌
        else if (other.tag == "Spot") 
        {
            StartCoroutine(EffectMgr.CameraShake(Camera.main.transform, 0.25f, 0.3f));
            spotCount++;

            Debug.Log("Spot");
            other.gameObject.SetActive(false);
        }
        else
        {
            if (isInvincibility)
                return;

            gasFigure -= 0.3f; // 데미지로 교체

            EffectMgr.SliderValue(slider, gasFigure);
            StartCoroutine(EffectMgr.CameraShake(Camera.main.transform, 0.10f, 0.15f));

            other.gameObject.SetActive(false);
            Debug.Log(gasFigure);

        }
    }

    void HandleInput()
    {
        moveVector = PoolInput();
    }

    Vector3 PoolInput()
    {
        float h = TouchPed.GetHorizontalValue();
        float v = TouchPed.GetVerticalValue();

        Vector3 moveDir = new Vector3(h, v, 0).normalized;
        return moveDir;
    }

    void Move()
    {
        if (!isBoost)
        {
            transform.Translate(moveVector * moveSpeed * Time.deltaTime);
        } else {
            StartCoroutine(EffectMgr.CameraShake(Camera.main.transform, 0.25f, 0.3f));
            transform.position = TouchPed.MousePosition;
            gasFigure -= 2.0f;
            isBoost = false;
            Invoke("SetInvincibility", 1f);
        }
    }

    void SetInvincibility()
    {
        Debug.Log(isInvincibility);
        isInvincibility = !isInvincibility;
    }
}
