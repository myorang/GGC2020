using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    Color color;
    public Image[] image;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine("GameOverScene");
    }

    IEnumerator GameOverScene()
    {
        float opecity = 1f;
        while (opecity >= 0f)
        {
            Debug.Log(opecity);
            opecity -= Time.deltaTime;
            image[0].color = new Color(0, 0, 0, opecity);
            yield return new WaitForSeconds(0.05f);
        }
        image[1].color = new Color(255, 255, 255, 255);
        image[2].color = new Color(255, 255, 255, 255);
    }
}
