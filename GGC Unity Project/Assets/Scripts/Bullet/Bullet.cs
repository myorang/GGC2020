using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BulletType
{
    Orbit,
    Guide,
    Boom,
    Reflect,
    Sniping,
    Cherry,
    UnSniping
}

public class Bullet : MonoBehaviour
{
    public static string CanvasName = "Canvas";
    public static Canvas canvas;

    public float angle;
    public float angleRate;
    public float speed;
    public float speedRate;

    public BulletType bulletType = BulletType.Orbit;

    private void Start()
    {
        canvas = GameObject.Find(CanvasName).GetComponent<Canvas>();
    }

    public bool IsOutToCameraview()
    {

        Vector3 view = Camera.main.WorldToScreenPoint(transform.position);
        if (view.y < -50
            || view.y > canvas.pixelRect.height + 50
            || view.x < -50
            || view.x > canvas.pixelRect.width + 50)
            return true;

        return false;

    }

    public void Initialized()
    {
    }

    private void Update()
    {
    }
}