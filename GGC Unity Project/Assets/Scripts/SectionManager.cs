using UnityEngine;
using System.Collections.Generic;

public class SectionManager : MonoBehaviour
{
    public Section A1, A2, A3, A4;
    public Section B1, B2, B3, B4, B5, B6, B7, B8, B9;
    public void Init()
    {
        #region
        //A1 = new Section
        //{
        //    length = 0.606f * 4f,
        //    interval = 0.606f,
        //    patterns = new List<BulletPattern>()
        //{
        //    new BulletPattern()
        //    {
        //        bulletCreatorType = BulletCreatorType.NWay,
        //        bulletType = BulletType.Boom,

        //        minAngleRate = -0.59f,
        //        maxAngleRate = -0.7f,
        //        minAngle = 225f,
        //        maxAngle = 255f,
        //        minSpeed = 7f,
        //        maxSpeed = 8f,
        //        bulletCount = 3,

        //        lifeTime = 0.606f * 3f,
        //        boomPatternIndex = 0,

        //        createPivotIndex = 0
        //    },
        //    new BulletPattern()
        //    {
        //        bulletCreatorType = BulletCreatorType.NWay,
        //        bulletType = BulletType.Orbit,

        //        minAngleRate = -0.59f,
        //        maxAngleRate = -0.7f,
        //        minAngle = 225f,
        //        maxAngle = 255f,
        //        minSpeed = 7f,
        //        maxSpeed = 8f,
        //        bulletCount = 3,

        //        lifeTime = 0.606f * 2f,
        //        boomPatternIndex = 0,

        //        createPivotIndex = 0
        //    },
        //    new BulletPattern()
        //    {
        //        bulletCreatorType = BulletCreatorType.NWay,
        //        bulletType = BulletType.Orbit,

        //        minAngleRate = -0.59f,
        //        maxAngleRate = -0.7f,
        //        minAngle = 225f,
        //        maxAngle = 255f,
        //        minSpeed = 7f,
        //        maxSpeed = 8f,
        //        bulletCount = 3,

        //        lifeTime = 0.606f * 1f,
        //        boomPatternIndex = 0,

        //        createPivotIndex = 0
        //    },
        //    new BulletPattern()
        //    {
        //        bulletCreatorType = BulletCreatorType.NWay,
        //        bulletType = BulletType.Orbit,

        //        minAngleRate = -0.59f,
        //        maxAngleRate = -0.7f,
        //        minAngle = 225f,
        //        maxAngle = 255f,
        //        minSpeed = 7f,
        //        maxSpeed = 8f,
        //        bulletCount = 3,

        //        lifeTime = 0.606f * 2f,
        //        boomPatternIndex = 0,

        //        createPivotIndex = 0
        //    },
        //},
        //    boomPatterns = new List<BulletPattern>()
        //{
        //    new BulletPattern()
        //    {
        //        bulletCreatorType = BulletCreatorType.Circle,
        //        bulletType = BulletType.Orbit,

        //        minSpeed = 4f,
        //        maxSpeed = 4f,
        //        bulletCount = 6,

        //        createPivotIndex = 0
        //    }
        //}
        //};
        //A2 = new Section
        //{
        //    length = 0.606f * 4f,
        //    interval = 0.606f,
        //    patterns = new List<BulletPattern>()
        //{
        //    new BulletPattern()
        //    {
        //        bulletCreatorType = BulletCreatorType.NWay,
        //        bulletType = BulletType.Orbit,

        //        minAngleRate = -0.59f,
        //        maxAngleRate = -0.7f,
        //        minAngle = 225f,
        //        maxAngle = 255f,
        //        minSpeed = 7f,
        //        maxSpeed = 8f,
        //        bulletCount = 2,

        //        createPivotIndex = 0
        //    },
        //}
        //};
        //A3 = new Section
        //{
        //    length = 0.606f * 4f,
        //    interval = 0.606f,
        //    patterns = new List<BulletPattern>()
        //{
        //    new BulletPattern()
        //    {
        //        bulletCreatorType = BulletCreatorType.NWay,
        //        bulletType = BulletType.Orbit,

        //        minAngleRate = -0.59f,
        //        maxAngleRate = -0.7f,
        //        minAngle = 225f,
        //        maxAngle = 255f,
        //        minSpeed = 7f,
        //        maxSpeed = 8f,
        //        bulletCount = 2,

        //        createPivotIndex = 0
        //    },
        //}
        //};
        //A4 = new Section
        //{
        //    length = 0.606f * 4f,
        //    interval = 0.606f,
        //    patterns = new List<BulletPattern>()
        //{
        //    new BulletPattern()
        //    {
        //        bulletCreatorType = BulletCreatorType.NWay,
        //        bulletType = BulletType.Boom,

        //        minAngleRate = -0.59f,
        //        maxAngleRate = -0.7f,
        //        minAngle = 225f,
        //        maxAngle = 255f,
        //        minSpeed = 7f,
        //        maxSpeed = 8f,
        //        bulletCount = 3,

        //        lifeTime = 0.606f * 3f,
        //        boomPatternIndex = 0,

        //        createPivotIndex = 0
        //    },
        //    new BulletPattern()
        //    {
        //        bulletCreatorType = BulletCreatorType.NWay,
        //        bulletType = BulletType.Orbit,

        //        minAngleRate = -0.59f,
        //        maxAngleRate = -0.7f,
        //        minAngle = 225f,
        //        maxAngle = 255f,
        //        minSpeed = 7f,
        //        maxSpeed = 8f,
        //        bulletCount = 3,

        //        lifeTime = 0.606f * 2f,
        //        boomPatternIndex = 0,

        //        createPivotIndex = 0
        //    },
        //    new BulletPattern()
        //    {
        //        bulletCreatorType = BulletCreatorType.NWay,
        //        bulletType = BulletType.Orbit,

        //        minAngleRate = -0.59f,
        //        maxAngleRate = -0.7f,
        //        minAngle = 225f,
        //        maxAngle = 255f,
        //        minSpeed = 7f,
        //        maxSpeed = 8f,
        //        bulletCount = 3,

        //        lifeTime = 0.606f * 1f,
        //        boomPatternIndex = 0,

        //        createPivotIndex = 0
        //    },
        //    new BulletPattern()
        //    {
        //        bulletCreatorType = BulletCreatorType.NWay,
        //        bulletType = BulletType.Orbit,

        //        minAngleRate = -0.59f,
        //        maxAngleRate = -0.7f,
        //        minAngle = 225f,
        //        maxAngle = 255f,
        //        minSpeed = 7f,
        //        maxSpeed = 8f,
        //        bulletCount = 3,

        //        lifeTime = 0.606f * 2f,
        //        boomPatternIndex = 0,

        //        createPivotIndex = 0
        //    },
        //},
        //    boomPatterns = new List<BulletPattern>()
        //{
        //    new BulletPattern()
        //    {
        //        bulletCreatorType = BulletCreatorType.Circle,
        //        bulletType = BulletType.Orbit,

        //        minSpeed = 4f,
        //        maxSpeed = 4f,
        //        bulletCount = 6,

        //        createPivotIndex = 0
        //    }
        //}
        //};
        #endregion

        B1 = new Section
        {
            isShoot = false,

            length = 9.4f,
            interval = 9.4f,
            patterns = new List<List<BulletPattern>>()
        };

        B2 = new Section
        {
            length = 9.4f,
            interval = 0.59f,
            patterns = new List<List<BulletPattern>>()
            {
                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                }
            },
        };

        B3 = new Section
        {
            length = 9.4f,
            interval = 0.59f,
            patterns = new List<List<BulletPattern>>()
            {
                new List<BulletPattern>()
                {
                    // 1-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    // 2-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                }
            },
        };

        int b4bulletCount = 15;
        
        B4 = new Section
        {
            length = 9.4f,
            interval = 0.295f,
            patterns = new List<List<BulletPattern>>()
            {
                new List<BulletPattern>()
                {
                    // 1-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 1-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 2
                    },
                },
                new List<BulletPattern>()
                {
                    // 2-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                },
                new List<BulletPattern>()
                {
                    // 3-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                    // 3-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 6
                    },
                },
                new List<BulletPattern>()
                {
                    // 4-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },
                new List<BulletPattern>()
                {
                    // 5-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 5-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 5
                    },
                },
                new List<BulletPattern>()
                {
                    // 6-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },
                new List<BulletPattern>()
                {
                    // 7-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                    // 7-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 3
                    },
                },
                new List<BulletPattern>()
                {
                    // 8-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },
                new List<BulletPattern>()
                {
                    // 9-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 9-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 6
                    },
                },
                new List<BulletPattern>()
                {
                    // 10-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                },
                new List<BulletPattern>()
                {
                    // 11-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                    // 11-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 2
                    },
                },
                new List<BulletPattern>()
                {
                    // 12-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },
                new List<BulletPattern>()
                {
                    // 13-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 13-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 3
                    },
                },
                new List<BulletPattern>()
                {
                    // 14-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },
                new List<BulletPattern>()
                {
                    // 15-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                    // 15-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 5
                    },
                },
                new List<BulletPattern>()
                {
                    // 16-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                }
            },
        };

        // No.3 + No.6
        B5 = new Section
        {
            length = 9.4f,
            interval = 0.295f,
            patterns = new List<List<BulletPattern>>()
            {
                new List<BulletPattern>()
                {
                    // 1-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = 20,

                        createPivotIndex = 0
                    },
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 2
                    },
                },
                new List<BulletPattern>()
                {
                    // 2-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 6
                    },
                },
                new List<BulletPattern>()
                {
                    // 3-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },
                new List<BulletPattern>()
                {
                    // 4-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 3
                    },
                },

                new List<BulletPattern>()
                {
                    // 5-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        startAngle = 360f/20f/2f,
                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = 20,

                        createPivotIndex = 0
                    },
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 5
                    },
                },
                new List<BulletPattern>()
                {
                    // 6-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },
                new List<BulletPattern>()
                {
                    // 7-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                },
                new List<BulletPattern>()
                {
                    // 8-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                },

                new List<BulletPattern>()
                {
                    // 9-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = 20,

                        createPivotIndex = 1
                    },
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 6
                    },
                },
                new List<BulletPattern>()
                {
                    // 10-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 2
                    },
                },
                new List<BulletPattern>()
                {
                    // 11-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },
                new List<BulletPattern>()
                {
                    // 12-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 5
                    },
                },

                new List<BulletPattern>()
                {
                    // 13-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        startAngle = 360f/20f/2f,
                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = 20,

                        createPivotIndex = 1
                    },
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 3
                    },
                },
                new List<BulletPattern>()
                {
                    // 14-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },
                new List<BulletPattern>()
                {
                    // 15-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                },
                new List<BulletPattern>()
                {
                    // 16-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                },
            },
        };

        // No.1 +  No.2`
        B6 = new Section
        {
            length = 9.4f,
            interval = 0.295f,
            patterns = new List<List<BulletPattern>>()
            {
                new List<BulletPattern>()
                {
                    // 1-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 1-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 2
                    },
                },

                new List<BulletPattern>()
                {
                    // 2-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                    // 2-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                },

                new List<BulletPattern>()
                {
                    // 3-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 3-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 6
                    },
                },

                new List<BulletPattern>()
                {
                    // 4-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },

                new List<BulletPattern>()
                {
                    // 5-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 5-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 5
                    },
                },

                new List<BulletPattern>()
                {
                    // 6-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                },

                new List<BulletPattern>()
                {
                    // 7-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 7-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 3
                    },
                },

                new List<BulletPattern>()
                {
                    // 8-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },

                new List<BulletPattern>()
                {
                    // 9-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 9-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 6
                    },
                },

                new List<BulletPattern>()
                {
                    // 10-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                    // 10-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                },

                new List<BulletPattern>()
                {
                    // 11-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 11-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 2
                    },
                },

                new List<BulletPattern>()
                {
                    // 12-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },

                new List<BulletPattern>()
                {
                    // 13-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 13-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 3
                    },
                },

                new List<BulletPattern>()
                {
                    // 14-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                },

                new List<BulletPattern>()
                {
                    // 15-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 15-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 5
                    },
                },

                new List<BulletPattern>()
                {
                    // 16-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                },
            },
        };


        B7 = new Section
        {
            length = 9.4f,
            interval = 0.295f,
            patterns = new List<List<BulletPattern>>()
            {
                new List<BulletPattern>()
                {
                    // 1-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = 20,

                        createPivotIndex = 0
                    },
                    // 1-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 2
                    },
                    // 1-3
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                },
                new List<BulletPattern>()
                {
                    // 2-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 6
                    },
                },
                new List<BulletPattern>()
                {
                    // 3-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                    // 3-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    // 4-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 3
                    },
                },

                new List<BulletPattern>()
                {
                    // 5-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        startAngle = 360f/20f/2f,
                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = 20,

                        createPivotIndex = 0
                    },
                    // 5-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 5
                    },
                    // 5-3
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                },
                new List<BulletPattern>()
                {
                    // 6-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },
                new List<BulletPattern>()
                {
                    // 7-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                    // 7-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    // 8-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                },

                new List<BulletPattern>()
                {
                    // 9-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = 20,

                        createPivotIndex = 1
                    },
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 6
                    },
                    // 9-3
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                },
                new List<BulletPattern>()
                {
                    // 10-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 2
                    },
                },
                new List<BulletPattern>()
                {
                    // 11-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                    // 3-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    // 12-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 5
                    },
                },

                new List<BulletPattern>()
                {
                    // 13-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        startAngle = 360f/20f/2f,
                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = 20,

                        createPivotIndex = 1
                    },
                    // 13-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 3
                    },
                    // 13-3
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                },
                new List<BulletPattern>()
                {
                    // 14-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },
                new List<BulletPattern>()
                {
                    // 15-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                    // 15-3
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    // 16-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                },
            },
        };

        B8 = new Section
        {
            length = 9.4f,
            interval = 0.295f,
            patterns = new List<List<BulletPattern>>()
            {
                new List<BulletPattern>()
                {
                    // 1-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = 20,

                        createPivotIndex = 0
                    },
                    // 1-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 2
                    },
                    // 1-3
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                },
                new List<BulletPattern>()
                {
                    // 2-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 6
                    },
                },
                new List<BulletPattern>()
                {
                    // 3-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                    // 3-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 3-3
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 2
                    },
                },
                new List<BulletPattern>()
                {
                    // 4-1
                },

                new List<BulletPattern>()
                {
                    // 5-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        startAngle = 360f/20f/2f,
                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = 20,

                        createPivotIndex = 0
                    },
                    // 5-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 5
                    },
                    // 5-3
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                },
                new List<BulletPattern>()
                {
                    // 6-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },
                new List<BulletPattern>()
                {
                    // 7-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                    // 7-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    // 8-1
                },

                new List<BulletPattern>()
                {
                    // 9-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = 20,

                        createPivotIndex = 1
                    },
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 6
                    },
                    // 9-3
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                },
                new List<BulletPattern>()
                {
                    // 10-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 2
                    },
                },
                new List<BulletPattern>()
                {
                    // 11-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                    // 11-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                    // 11-3
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 6
                    },
                },
                new List<BulletPattern>()
                {
                    // 12-1
                },

                new List<BulletPattern>()
                {
                    // 13-1
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        startAngle = 360f/20f/2f,
                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = 20,

                        createPivotIndex = 1
                    },
                    // 13-2
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 3
                    },
                    // 13-3
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 1
                    },
                },
                new List<BulletPattern>()
                {
                    // 14-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                },
                new List<BulletPattern>()
                {
                    // 15-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                    // 15-3
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Cherry,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    // 16-1
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.Circle,
                        bulletType = BulletType.Orbit,

                        minSpeed = 8f,
                        maxSpeed = 8f,
                        bulletCount = b4bulletCount,

                        createPivotIndex = 4
                    },
                },
            },
        };

        B9 = new Section
        {
            length = 9.4f,
            interval = 0.295f,
            patterns = new List<List<BulletPattern>>()
            {
                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Boom,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 2,

                        lifeTime = 1.18f,
                        boomPatternIndex = 0,

                        createPivotIndex = 0
                    },
                },

                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Boom,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 2,

                        createPivotIndex = 1,

                        lifeTime = 1.18f,
                        boomPatternIndex = 0,
                    },
                },

                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Boom,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 2,

                        lifeTime = 1.18f,
                        boomPatternIndex = 0,

                        createPivotIndex = 0
                    },
                },

                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Boom,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 2,

                        createPivotIndex = 1,

                        lifeTime = 1.18f,
                        boomPatternIndex = 0,
                    },
                },

                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Boom,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 2,

                        lifeTime = 1.18f,
                        boomPatternIndex = 0,

                        createPivotIndex = 0
                    },
                },


                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Boom,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 175f,
                        maxAngle = 205f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 2,

                        createPivotIndex = 1,

                        lifeTime = 0.59f,
                        boomPatternIndex = 0
                    },
                },

                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 4,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Boom,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 255f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 2,

                        lifeTime = 1.18f,
                        boomPatternIndex = 0,

                        createPivotIndex = 0
                    },
                },

                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        bulletCreatorType = BulletCreatorType.NWay,
                        bulletType = BulletType.Orbit,

                        minAngleRate = -0.59f,
                        maxAngleRate = -0.7f,
                        minAngle = 225f,
                        maxAngle = 275f,
                        minSpeed = 7f,
                        maxSpeed = 8f,
                        bulletCount = 3,

                        createPivotIndex = 0
                    },
                },
                new List<BulletPattern>()
                {
                    new BulletPattern()
                    {
                        isShoot = false
                    },
                }
            },
            boomPatterns = new List<BulletPattern>()
            {
                new BulletPattern()
                {
                    bulletCreatorType = BulletCreatorType.Circle,
                    bulletType = BulletType.Cherry,

                    minSpeed = 5f,
                    maxSpeed = 5f,
                    bulletCount = 15,

                    createPivotIndex = 4
                },
            }
        };
    }
}
