using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFigure : MonoBehaviour
{
    [SerializeField] [Tooltip("연료 수치")] float gasFigure = 10f;
    [SerializeField] [Tooltip("이동 속도")] float moveSpeed = 5f;

    private Vector3 moveVector;

    // 소환한 오브젝트를 받아오는 변수
    GameObject[] obj;

    void Start()
    {
        moveVector = Vector3.zero;
    }

    void Update()
    {
        HandleInput();
    }

    void FixedUpdate()
    {
        Move();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Tag 확인
        gasFigure -= 1f; // 데미지로 교체

        obj = EffectMgr.SpawnSprite("Particle 1", transform, 3);

        //StartCoroutine(EffectMgr.DisableSprite(obj, 1f));

        other.gameObject.SetActive(false);
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
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
    }
}
