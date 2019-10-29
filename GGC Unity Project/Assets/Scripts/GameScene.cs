using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{
    void Awake()
    {
        // 함수를 받아주고 버튼을 클릭했을 때 그 함수를 실행시킨다
        //transform.Find("Button").GetComponent<UIMgr>().Click = () =>
        //{
        //    Debug.Log("Push");
        //    SceneMgr.LoadingScene(SceneMgr.Scene.Game);
        //};
        SceneMgr.LoadingScene(SceneMgr.Scene.Game);

    }
}
