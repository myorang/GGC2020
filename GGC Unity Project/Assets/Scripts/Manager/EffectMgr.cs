using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EffectMgr : MonoBehaviour
{
    // 오브젝트 풀로 생성된 오브젝트를 지정된 위치에 생성해주는 함수
    public static void SpawnSprite(string spriteName, Transform transform, int spawnCount)
    {
        // 개수 초과
        Debug.Log(ObjectMgr.Instance.poolDictionary[spriteName].Count);

        if (spawnCount > ObjectMgr.Instance.poolDictionary[spriteName].Count) { print("Over Count"); return; }

        for (int i = 0; i < spawnCount; i++)
        {
            //float r = Random.Range(1f, 10f);      
            //ObjectMgr.Instance.SpawnFromPool(spriteName, new Vector3(transform.position.x + r, transform.position.y + r), transform.rotation);

            ObjectMgr.Instance.SpawnFromPool(spriteName, transform.position, transform.rotation);
        }
    }

    // 받아온 슬라이더의 값을 조정하는 함수
    public static void SliderValue(Slider slider, float value)
    {
        slider.value = value;
    }
}
