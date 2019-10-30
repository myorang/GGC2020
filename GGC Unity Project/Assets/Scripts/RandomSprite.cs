using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : Singleton<RandomSprite>
{
    public Sprite[] sprites;

    public Sprite GetSprite()
    {
        return sprites[Random.Range(0, sprites.Length)];
    }
}
