using UnityEngine;
using System.Collections;

public class BulletGuided : Bullet
{
    private Vector3 vec3MoveTarget;
    private Transform player;

    public bool isGuided = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speed += speedRate * Time.deltaTime;
        Vector3 dir = Vector3.zero;
        if (isGuided)
        {
            dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
            dir.Normalize();
        }
        else
        {
            dir = Vector3.left;
        }
        transform.position = dir * speed * Time.deltaTime;
    }

    public void EndGuided()
    {
        isGuided = false;
    }
}
