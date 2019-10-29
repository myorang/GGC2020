using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFigure : MonoBehaviour
{
    [SerializeField] [Tooltip("연료 수치")] float gasFigure = 10f;

    // 소환한 오브젝트를 받아오는 변수
    GameObject[] obj;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        // Tag 확인
        gasFigure -= 1f; // 데미지로 교체

        obj = EffectMgr.SpawnSprite("Particle 1", transform, 3);

        //StartCoroutine(EffectMgr.DisableSprite(obj, 1f));

        other.gameObject.SetActive(false);
    }
}
