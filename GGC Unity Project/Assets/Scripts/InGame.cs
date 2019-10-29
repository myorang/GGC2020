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
        EffectMgr.SpawnSprite("Particle 1",transform, 3);
        SoundMgr.Instance.PlayLoopSound("TestBgm","BGM");
    }
    void Update()
    {
        EffectMgr.SliderValue(slider, value);
    }
}
