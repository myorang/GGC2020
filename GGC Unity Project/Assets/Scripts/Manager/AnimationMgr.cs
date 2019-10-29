using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AnimationMgr : MonoBehaviour
{
    #region Public 

    [SerializeField] [Tooltip("애니메이션이 적용될 스프라이트")] private Sprite[] sprites;
  
    SpriteRenderer spriteR;

    // 애니메이션 멈추는 변수
    static bool isStop = false;

    #endregion

    void Awake()
    {
        spriteR = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        StartCoroutine(Animation(0.25f));
    }

    public IEnumerator Animation(float changeSpeed = 0.25f)
    {
        // Enter
        int sequence = 0;
        int count = sprites.Length;
        yield return null;
        
        while (!isStop)
        {
            // Update
            Debug.Log("Playing ... ");
            spriteR.sprite = sprites[sequence];
            sequence++;

            if (sequence == count)
                sequence = 0;

            yield return new WaitForSeconds(changeSpeed);
        }

        // Exit
        isStop = true;
    }

    public static void AnimationStop()
    {
        isStop = false;
    }
}
