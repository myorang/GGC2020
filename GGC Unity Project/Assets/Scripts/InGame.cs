using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGame : MonoBehaviour
{ 
    public Slider slider;

    [Range(0f, 1f)]
    public float value;

    void Start()
    {
        //EffectMgr.SpawnSprite("Particle 1", transform, 10);
        //SoundMgr.Instance.PlayLoopSound("TestBgm","BGM");
    }
    void Update()
    {
        //EffectMgr.SpawnSprite("Particle 1", transform, 1);
        EffectMgr.SliderValue(slider, value);
    }
}
