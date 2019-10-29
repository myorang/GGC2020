using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMgr : Singleton<SoundMgr>
{
    #region Public

    // 오디오 클립을 저장할 변수
    public AudioClip[] sfxClips;
    public AudioClip[] bgmClips;
    public Dictionary<string, AudioClip> clipsDictionary;

    #endregion

    #region Private

    // 오디오 플레이 변수
    AudioSource sfxPlayer;
    AudioSource bgmPlayer;

    private float sfxVolume = 1f;
    private float bgmVolume = 1f;

    #endregion

    void Awake()
    {
        sfxPlayer = GetComponent<AudioSource>();
        bgmPlayer = transform.GetChild(0).GetComponent<AudioSource>();

        clipsDictionary = new Dictionary<string, AudioClip>();
        foreach (AudioClip clip in sfxClips)
        {
            clipsDictionary.Add(clip.name, clip);
        }
        foreach (AudioClip clip in bgmClips)
        {
            clipsDictionary.Add(clip.name, clip);
        }
    }

    void Start()
    {
        if (bgmPlayer.clip != null)
            bgmPlayer.Play();
    }

    // 추가된 클립의 sfx를 재생 시켜주는 함수
    public void PlaySfxSound(string clipname, bool fadeIn = false, float volume = 1f)
    {
        if (clipsDictionary.ContainsKey(clipname) == false)
        {
            Debug.Log("Couldn't find it");
            return;
        }

        if (fadeIn)
        {
            sfxPlayer.PlayOneShot(clipsDictionary[clipname], volume * sfxVolume);
            StartCoroutine(FadeIn("SFX"));
        } else { 
            sfxPlayer.PlayOneShot(clipsDictionary[clipname], volume * sfxVolume);
        }
    }

    // 추가된 클립의 bgm을 재생 시켜주는 함수
    public void PlayBgmSound(string clipname, bool fadeIn = false, float volume = 1f)
    {
        if (clipsDictionary.ContainsKey(clipname) == false)
        {
            Debug.Log("Couldn't find it");
            return;
        }

        if (fadeIn)
        {
            StopBGM();

            bgmPlayer.clip = clipsDictionary[clipname];
            bgmPlayer.Play();

            StartCoroutine(FadeIn("BGM"));
        } else {
            bgmPlayer.PlayOneShot(clipsDictionary[clipname], volume * sfxVolume);
        }
    }

    // 반복 재생
    public GameObject PlayLoopSound(string clipname, string kind, bool fadeIn = false)
    {
        // 자식에 LoopSound 라는 오브젝트를 만들고 그 오브젝트안에다가 루프할 사운드를 심어서 계속 플레이 시킨다.

        if (clipsDictionary.ContainsKey(clipname) == false)
        {
            Debug.Log("Couldn't find it");
            return null;
        }

        if (kind == "BGM")
            bgmPlayer.Stop();

        GameObject loopClip = new GameObject("LoopSound"); loopClip.transform.parent = transform;
        AudioSource source = loopClip.AddComponent<AudioSource>();

        source.clip = clipsDictionary[clipname];
        source.volume = sfxVolume;
        source.loop = true;
        source.Play();

        return loopClip;
    }

    public void StopBGM(bool fadeOut = false)
    {
        if (fadeOut)
        {
            // Fade Out
            StartCoroutine(FadeOut("BGM"));
        } else {
            bgmPlayer.Stop();
        }
    }

    public void SetSFX(float volume)
    {
        sfxVolume = volume;
    }

    public void SetBGM(float volume)
    {
        bgmPlayer.volume = volume;
    }

    // 서서히 소리를 늘려주는 함수
    // true = 함수 성공 false = 함수 실패
    public IEnumerator FadeIn(string kind, float amount = 0.01f)
    {
        float volume = 0.0f;

        while (volume <= 1f)
        {
            Debug.Log("Fade In : " + volume);

            if (kind == "SFX")
                sfxPlayer.volume = volume;
            else if (kind == "BGM")
                bgmPlayer.volume = volume;
            else
                StopCoroutine("FadeIn");

            volume += amount;
            yield return null;
        }
        if (kind == "SFX")
            SetSFX(1f);
        else if (kind == "BGM")
            SetBGM(1f);
    }

    // 서서히 소리를 줄여주는 함수
    // true = 함수 성공 false = 함수 실패
    public IEnumerator FadeOut(string kind, float amount = 0.01f)
    {
        float volume = 1.0f;

        while (volume >= 0f)
        {
            Debug.Log("Fade Out : " + volume);

            if (kind == "SFX")
                sfxPlayer.volume = volume;
            else if (kind == "BGM")
                bgmPlayer.volume = volume;
            else
                StopCoroutine("FadeOut");

            volume -= amount;
            yield return null;
        }
        if (kind == "SFX")
            SetSFX(1f);
        else if (kind == "BGM")
            SetBGM(1f);
        bgmPlayer.Stop();
    }
}
