using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour
{
    [SerializeField] GameObject[] storys;
    
    int count = 0;

    public void PrologeButtonClick()
    {
        storys[count].SetActive(false);
        count++;

        if (count < storys.Length)
            storys[count].SetActive(true);
        else
            SceneMgr.LoadingScene(SceneMgr.Scene.Game);
    }

    public void EpilogueButtonClick()
    {
        storys[count].SetActive(false);
        count++;

        if (count < storys.Length)
            storys[count].SetActive(true);
        else
            SceneMgr.LoadingScene(SceneMgr.Scene.Main);
    }
}
