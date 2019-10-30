using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EffectMgr : MonoBehaviour
{
    // 오브젝트 풀로 생성된 오브젝트를 지정된 위치에 생성해주는 함수
    public static GameObject[] SpawnSprite(string spriteName, Transform transform, int spawnCount)
    {
        // 개수 초과
        GameObject[] obj = new GameObject[spawnCount];

        if (spawnCount > ObjectMgr.Instance.poolDictionary[spriteName].Count) { print("Over Count"); return null; }

        for (int i = 0; i < spawnCount; i++)
        {
            obj[i] = ObjectMgr.Instance.SpawnFromPool(spriteName, transform.position, transform.rotation);
        }
        return obj;
    }

    public static IEnumerator DisableSprite(GameObject[] obj, float time)
    {
        float progress = 0f;
        yield return null;

        while (progress <= time)
        {
            progress += Time.deltaTime;
            yield return null;
        }
        for (int i = 0; i < obj.Length; i++)
            obj[i].SetActive(false);
    }

    public static IEnumerator CameraShake(Transform trans, float magnitude, float duration)
    {
        Vector3 originalPos = trans.localPosition;

        float progress = 0f;

        while (progress <= duration)
        {
            progress += Time.deltaTime;

            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            trans.localPosition = new Vector3(x, y, originalPos.z);

            yield return null;
        }
        trans.localPosition = originalPos;
    }

    // 받아온 슬라이더의 값을 조정하는 함수
    public static void SliderValue(Slider slider, float value)
    {
        slider.value = value;
    }
}
