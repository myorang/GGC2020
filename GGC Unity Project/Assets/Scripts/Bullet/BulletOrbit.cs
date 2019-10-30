using UnityEngine;
using System.Collections;

public class BulletOrbit : Bullet
{
    void Update()
    {
        if (IsOutToCameraview())
            gameObject.SetActive(false);

        angle += angleRate;

        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        speed += speedRate * Time.deltaTime;
        Vector3 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;

        transform.position += dir.normalized * speed * Time.deltaTime;
    }
}
