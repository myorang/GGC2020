using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMgr : MonoBehaviour
{
    #region Private

    private class LoadingMB : MonoBehaviour { }

    #endregion

    #region Public

    public enum Scene
    {
        Main = 0,
        Loading,
        Stage,
        Game2,
        GameOver,
        Prologue,
        Epilogue
    };
    static Action nextScene;
    static AsyncOperation asyncOperation;

    #endregion

    // 씬을 교체하는 함수
    public static void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    // 무명 함수로 다음으로 넘어갈 씬을 지정해주고 로딩씬으로 교체하는 함수
    public static void LoadingScene(Scene scene)
    {
        nextScene = () =>
        {
            GameObject loadingMB = new GameObject("Loading ...");
            loadingMB.AddComponent<LoadingMB>().StartCoroutine(LoadSceneAsync(scene));
        };

        LoadScene(Scene.Loading);
    }

    // LoadSceneAsync 함수를 그대로 만든 함수
    static IEnumerator LoadSceneAsync(Scene scene)
    {
        yield return null;
        asyncOperation = SceneManager.LoadSceneAsync(scene.ToString());

        // 진행중 일 때
        while (!asyncOperation.isDone)
        {
            //Debug.Log(asyncOperation.progress);
            yield return null;
        }
    }

    // 현재 로딩된 값을 얻어오는 함수
    public static float GetProgress()
    {
        if (asyncOperation != null)
        {
            return asyncOperation.progress;
        } else {
            return 1f;
        }
    }

    // 콜백함수
    public static void CallBackScene()
    {
        if (nextScene != null)
        {
            nextScene();
            nextScene = null;
        }
    }
}
