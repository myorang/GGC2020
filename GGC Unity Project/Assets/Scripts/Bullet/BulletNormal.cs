using UnityEngine;
using System.Collections;

public class BulletNormal : Bullet
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsOutToCameraview())
            gameObject.SetActive(false);

        angle += angleRate;

        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        speed += speedRate;
        Vector3 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
        transform.position += dir.normalized * speed * Time.deltaTime;
    }
}
