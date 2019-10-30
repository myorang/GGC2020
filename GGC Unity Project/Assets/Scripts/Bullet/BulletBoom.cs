using UnityEngine;
using System.Collections;

public class BulletBoom : Bullet
{
    public BulletPattern boomPattern;
    public float lifeTime;

    public Vector3 createPos = Vector3.zero;

    private void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0f)
        {
            Boom();
            gameObject.SetActive(false);

            return;
        }

        if (IsOutToCameraview())
        {
            gameObject.SetActive(false);
            return;
        }

        angle += angleRate;

        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        speed += speedRate;
        Vector3 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    public void Boom()
    {
        BulletManager.Instance.CreateBulletOnPattern(boomPattern, transform.position);

        //GameObject creator;
        //switch (boomPattern.bulletCreatorType)
        //{
        //    case BulletCreatorType.NWay:
        //        boomPattern.bulletCreatorName = string.Format("Bullet Creator NWay");
        //        creator = ObjectMgr.Instance.SpawnFromPool(boomPattern.bulletCreatorName, createPos, Quaternion.identity);
        //        creator.GetComponent<BulletCreatorNWay>().Init(boomPattern, creator.transform.position);
        //        break;

        //    default:
        //        break;
        //}
    }
}
