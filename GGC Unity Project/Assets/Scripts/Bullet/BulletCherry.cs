using UnityEngine;
using System.Collections;

public class BulletCherry : Bullet
{
    public float lastTime;
    public float h, v;

    void Update()
    {
        if (IsOutToCameraview())
            gameObject.SetActive(false);

        angle += angleRate;
        h = Mathf.PingPong(Time.time, 1f);
        h -= 0.5f;

        v = Mathf.PingPong(Time.time, 0.5f);
        
        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        speed += speedRate * Time.deltaTime;
        Vector3 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
        Vector3 dirH = Quaternion.AngleAxis(90f, Vector3.forward) * dir.normalized;
        Vector3 dirV = -dir;

        transform.position += (dir.normalized * (speed - v * 4) + dirH.normalized * h * 4) * Time.deltaTime;
    }
}
