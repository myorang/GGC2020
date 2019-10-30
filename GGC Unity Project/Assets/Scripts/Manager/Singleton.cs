using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance = null;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = (T)FindObjectOfType(typeof(T));
                if (_instance == null)
                {
                    _instance = new GameObject("Singleton").AddComponent<T>();
                }
            }
            return _instance;
        }
    }

    public void CheckGameObject(GameObject obj)
    {
        if (_instance != null && _instance != this)
        {
            DestroyImmediate(obj.gameObject);
        }
        else
        {
            _instance = (T)FindObjectOfType(typeof(T));
            //DontDestroyOnLoad(this.gameObject);
        }
    }
}
