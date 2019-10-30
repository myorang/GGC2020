using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    #region Public

    [SerializeField] [Tooltip("사용할 스프라이트 이름")] private Sprite sprite;
    [SerializeField] [Tooltip("실행시켜줄 클립 이름")] private string clipName;

    Image image;
    bool  isPause;

    #endregion

    void Awake()
    {
        image = GetComponent<Image>();

        if (sprite != null)
            image.sprite = sprite;
    }

    public void ButtonClick()
    {
        SoundMgr.Instance.PlaySfxSound(clipName, true);
    }

    public void PauseButtonClick()
    {
        isPause = !isPause;
        if (isPause) Time.timeScale = 0;
        else         Time.timeScale = 1;
    }

    public void BoostButtonClick()
    {
        PlayerFigure.isBoost = true;
        PlayerFigure.isInvincibility = true;
    }

    public void StartButtonClick()
    {
        SceneMgr.LoadingScene(SceneMgr.Scene.Stage);
    }

    public void ExitButtonClick()
    {
        SceneMgr.LoadingScene(SceneMgr.Scene.Main);
    }

    public void StageButtonClick()
    {
        SceneMgr.LoadingScene(SceneMgr.Scene.Prologue);
    }

    public void RetryButtonClick()
    {
        SceneMgr.LoadingScene(SceneMgr.Scene.Prologue);
    }
}