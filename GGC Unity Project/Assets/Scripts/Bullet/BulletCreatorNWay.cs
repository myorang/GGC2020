using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreatorNWay : MonoBehaviour
{
    public BulletPattern boomPattern;

    public BulletType bulletType;
    public string bulletTag;

    public float minAngleRate, maxAngleRate;
    public float minAngle, maxAngle;
    public float minSpeedRate, maxSpeedRate;
    public float minSpeed, maxSpeed;
    public int bulletCount;

    float angleRateRatio;
    float angleRatio;
    float speedRatio;
    float speedRateRatio;

    float lifeTime;

    public void Init(BulletPattern pattern, Vector3 createPosition)
    {
        _color = Color.white;
        transform.position = createPosition;

        bulletType = pattern.bulletType;
        bulletTag = BulletUtility.GetBulletTag(bulletType);

        minAngleRate = pattern.minAngleRate;
        maxAngleRate = pattern.maxAngleRate;
        minAngle = pattern.minAngle + pattern.startAngle;
        maxAngle = pattern.maxAngle + pattern.startAngle;
        minSpeed = pattern.minSpeed;
        maxSpeed = pattern.maxSpeed;
        minSpeedRate = pattern.minSpeedRate;
        maxSpeedRate = pattern.maxSpeedRate;
        bulletCount = pattern.bulletCount;

        angleRateRatio = (maxAngleRate - minAngleRate) / (bulletCount - 1);
        angleRatio = (maxAngle - minAngle) / (bulletCount - 1);
        speedRatio = (maxSpeed - minSpeed) / (bulletCount - 1);
        speedRateRatio = (maxSpeedRate - minSpeedRate) / (bulletCount - 1);

        //isBoom?
        if (bulletType == BulletType.Boom)
        {
            boomPattern = BulletManager.Instance.nowSection.boomPatterns[pattern.boomPatternIndex];
            lifeTime = pattern.lifeTime;
        }
        else
        {
            boomPattern = null;
            lifeTime = 0;
        }

        CreateBullets();
    }

    Color _color;
    public void Init(BulletPattern pattern, Vector3 createPosition, Color color2)
    {
        _color = color2;

        transform.position = createPosition;

        bulletType = pattern.bulletType;
        bulletTag = BulletUtility.GetBulletTag(bulletType);

        minAngleRate = pattern.minAngleRate;
        maxAngleRate = pattern.maxAngleRate;
        minAngle = pattern.minAngle + pattern.startAngle;
        maxAngle = pattern.maxAngle + pattern.startAngle;
        minSpeed = pattern.minSpeed;
        maxSpeed = pattern.maxSpeed;
        minSpeedRate = pattern.minSpeedRate;
        maxSpeedRate = pattern.maxSpeedRate;
        bulletCount = pattern.bulletCount;

        angleRateRatio = (maxAngleRate - minAngleRate) / (bulletCount - 1);
        angleRatio = (maxAngle - minAngle) / (bulletCount - 1);
        speedRatio = (maxSpeed - minSpeed) / (bulletCount - 1);
        speedRateRatio = (maxSpeedRate - minSpeedRate) / (bulletCount - 1);

        //isBoom?
        if (bulletType == BulletType.Boom)
        {
            boomPattern = BulletManager.Instance.nowSection.boomPatterns[pattern.boomPatternIndex];
            lifeTime = pattern.lifeTime;
        }
        else
        {
            boomPattern = null;
            lifeTime = 0;
        }

        CreateBullets();
    }

    public void CreateBullets()
    {
        for (int i = 0; i < bulletCount; i++)
        {
            GameObject bullet = ObjectMgr.Instance.SpawnFromPool(bulletTag, transform.position, Quaternion.identity);
            bullet.GetComponent<SpriteRenderer>().sprite = RandomSprite.Instance.GetSprite();
            Bullet bulletController = bullet.GetComponent<Bullet>();
            if (bulletController.bulletType == BulletType.Cherry)
            {
                bullet.GetComponent<SpriteRenderer>().color
                    = new Color(1f, 0.6f + 0.4f / bulletCount * i, 1f, 1f);
            }
            else if(bulletController.bulletType == BulletType.Boom)
            {
                bullet.GetComponent<SpriteRenderer>().color
                    = new Color(95f / 255f
                                , 65f / 255f + ((105f - 65f) / 255f) / bulletCount * i
                                , 0.3f + 0.3f / bulletCount * i, 1f);
            }
            else if (_color != Color.white)
            {
                bullet.GetComponent<SpriteRenderer>().color
                    = new Color(95f / 255f
                                , 1f
                                , 0.3f + 0.3f / bulletCount * i, 1f);

            }
            else
            {
                bullet.GetComponent<SpriteRenderer>().color
                    = new Color(0.5f + 0.5f / bulletCount * i
                                , 0.5f + 0.5f / bulletCount * i
                                , 1f, 1f);
            }

            bulletController.angle = minAngle + angleRatio * i;
            bulletController.angleRate = minAngleRate + angleRateRatio * i;
            bulletController.speed = minSpeed + speedRatio * i;
            bulletController.speedRate = minSpeedRate + speedRateRatio * i;

            if (bulletType == BulletType.Boom)
            {
                if (BulletManager.Instance.isTest)
                {
                    bullet.GetComponent<BulletBoom>().boomPattern = BulletManager.Instance.TestBoomPattern;
                }
                else
                {
                    bullet.GetComponent<BulletBoom>().boomPattern = boomPattern;
                }
                bullet.GetComponent<BulletBoom>().lifeTime = lifeTime;
            }
        }

        gameObject.SetActive(false);
    }
}
