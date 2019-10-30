using UnityEngine;
using System.Collections.Generic;


[System.Serializable]
public class Section
{
    public bool isShoot = true;
    public float length;
    public float interval; // 해당 섹션의 가장 빠른 박자
    public int patternIndex = 0;
    [SerializeField]
    public List<List<BulletPattern>> patterns;
    public List<BulletPattern> boomPatterns;
    
    public List<BulletPattern> GetNowPatterns()
    {
        if (patternIndex >= patterns.Count)
            patternIndex = 0;

        return patterns[patternIndex++];
    }
}
