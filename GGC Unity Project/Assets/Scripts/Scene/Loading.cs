using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Slider slider;

    bool isFirstUpdate = true;
    
    void Update()
    {
        if (isFirstUpdate)
        {
            slider.value = SceneMgr.GetProgress();

            SceneMgr.CallBackScene();
            isFirstUpdate = false;
        }
    }
}
