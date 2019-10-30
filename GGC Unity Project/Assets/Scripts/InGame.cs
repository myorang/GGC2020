using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGame : Singleton<InGame>
{
    public BulletManager bulletManager;
    public bool isMusicStart = false;
    public Slider slider;

    [Range(0f, 1f)]
    public float value;

    void Start()
    {
        StartCoroutine(GameStart());
    }

    public IEnumerator GameStart()
    {
        yield return new WaitForSeconds(1f);
        
        isMusicStart = true;

        //EffectMgr.SpawnSprite("Particle 1", transform, 3);
        SoundMgr.Instance.PlayLoopSound("phase3", "BGM");
        bulletManager.MusicStart();
    }

    void Update()
    {
        EffectMgr.SliderValue(slider, value);
    }
}
