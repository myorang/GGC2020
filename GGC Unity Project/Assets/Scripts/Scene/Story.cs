using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour
{
    [SerializeField] GameObject[] storys;
    
    int count = 0;

    public void PrologeButtonClick()
    {
        SoundMgr.Instance.PlaySfxSound("ButtonClick", false, 0.2f);
        storys[count].SetActive(false);
        count++;

        if (count < storys.Length)
            storys[count].SetActive(true);
        else
        {
            SceneMgr.LoadingScene(SceneMgr.Scene.Game2);
            SoundMgr.Instance.StopBGM();
        }
    }

    public void EpilogueButtonClick()
    {
        SoundMgr.Instance.PlaySfxSound("ButtonClick", false, 0.2f);
        storys[count].SetActive(false);
        count++;

        if (count < storys.Length)
            storys[count].SetActive(true);
        else
        {
            SceneMgr.LoadingScene(SceneMgr.Scene.Main);
            SoundMgr.Instance.StopBGM();
            SoundMgr.Instance.PlayBgmSound("phase2", false, 1f);
        }
    }
}
