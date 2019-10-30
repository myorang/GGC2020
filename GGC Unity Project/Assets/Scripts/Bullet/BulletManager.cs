using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletPattern
{
    public bool isShoot = true;

    public BulletCreatorType bulletCreatorType;
    public string bulletCreatorName;

    public BulletType bulletType;
    public float startAngle;
    public float minAngleRate, maxAngleRate;
    public float minAngle, maxAngle;
    public float minSpeed, maxSpeed;
    public float minSpeedRate, maxSpeedRate;
    public int bulletCount;
    public int createPivotIndex;

    [Header("Boom")]
    public float lifeTime;
    public int boomPatternIndex;
}

public enum BulletCreatorType
{
    NWay,
    Circle
}
public static class BulletUtility
{
    public static string GetBulletTag(BulletType bulletType)
    {
        string bulletTag = string.Empty;
        switch (bulletType)
        {
            case BulletType.Orbit:
                bulletTag = "Bullet Orbit";
                break;

            case BulletType.Guide:
                bulletTag = "Bullet Guide";
                break;

            case BulletType.Boom:
                bulletTag = "Bullet Boom";
                break;

            case BulletType.Reflect:
                break;

            case BulletType.Sniping:
                break;

            case BulletType.Cherry:
                bulletTag = "Bullet Cherry";
                break;

            case BulletType.UnSniping:
                break;

            default:
                Debug.Log("Couldn't find type");
                break;
        }
        return bulletTag;
    }
}

public class BulletManager : Singleton<BulletManager>
{
    public SectionManager sectionManager;

    [Header("Testment")]
    public bool isTest = false;
    public GameObject TestCreatrPivot;
    public BulletPattern PatternTest = new BulletPattern();
    public float patterInterval = 0.5f;
    public float sectionInterval = 9.4f;

    public BulletPattern TestBoomPattern = new BulletPattern()
    {
        bulletCreatorType = BulletCreatorType.NWay,
        bulletType = BulletType.Orbit,

        minAngleRate = -0.59f,
        maxAngleRate = -0.7f,
        minAngle = 225f,
        maxAngle = 255f,
        minSpeed = 7f,
        maxSpeed = 8f,
        bulletCount = 9
    };

    [Header("Used Data")]
    public List<BulletPattern> patterns = new List<BulletPattern>();
    public int patternsIndex = 0;

    private BulletPattern Pattern1 = new BulletPattern()
    {
        bulletCreatorType = BulletCreatorType.NWay,
        bulletType = BulletType.Orbit,

        minAngleRate = -0.59f,
        maxAngleRate = -0.7f,
        minAngle = 225f,
        maxAngle = 255f,
        minSpeed = 7f,
        maxSpeed = 8f,
        bulletCount = 9,

        createPivotIndex = 0
    };

    private BulletPattern Pattern2 = new BulletPattern()
    {
        bulletCreatorType = BulletCreatorType.Circle,
        bulletType = BulletType.Boom,

        minAngleRate = -0.59f,
        maxAngleRate = -0.7f,
        minAngle = 225f,
        maxAngle = 255f,
        minSpeed = 7f,
        maxSpeed = 8f,
        bulletCount = 9,

        lifeTime = 0.59f / 2f,
        boomPatternIndex = 2,

        createPivotIndex = 1
    };

    private BulletPattern Pattern2_Boom = new BulletPattern()
    {
        bulletCreatorType = BulletCreatorType.NWay,
        bulletType = BulletType.Orbit,

        minAngleRate = 0,
        maxAngleRate = 0,
        minAngle = 160f,
        maxAngle = 200f,
        minSpeed = 5f,
        maxSpeed = 5f,
        bulletCount = 3
    };


    public float patternIntervalDeltaTime = 0f;
    public int sectionCount = 0;
    public List<Transform> CreatePivots = new List<Transform>();
    public int createCount = 5;
    GameObject testCreator;

    [Header("Section")]
    [SerializeField]
    private List<Section> sections;
    public int sectionIndex = 0;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void MusicStart()
    {
        gameObject.SetActive(true);

        sectionManager.Init();

        sections = new List<Section>();
        //sections.Add(sectionManager.A1);
        //sections.Add(sectionManager.A2);
        //sections.Add(sectionManager.A3);
        //sections.Add(sectionManager.A4);

        sections.Add(sectionManager.B1); // [1]X
        sections.Add(sectionManager.B2); // [2]No.1
        sections.Add(sectionManager.B3); // [3]No.2
        sections.Add(sectionManager.B4); // [4]No.2 + No.4
        sections.Add(sectionManager.B4); // [5]NO.2 + No.4
        sections.Add(sectionManager.B5); // [6]NO.3 + No.6
        sections.Add(sectionManager.B5); // [7]NO.3 + No.6
        sections.Add(sectionManager.B6); // [8]No.5 + No.4
        sections.Add(sectionManager.B7); // [9]No.2 / No.3 + No.6(B5)
        sections.Add(sectionManager.B8); // [10]No.2 + No.4 / No.3
        sections.Add(sectionManager.B9); // [11]No.1
        sections.Add(sectionManager.B4); // [12]No.2 + No.4
        sections.Add(sectionManager.B1); // [13]X

        StartCoroutine(Interval());
    }

    [HideInInspector]
    public int intervalCount = 0;
    public Section nowSection;
    private IEnumerator Interval()
    {
        while (true)
        {
            nowSection = sections[sectionIndex];

            if (sectionCount >= nowSection.length / nowSection.interval)
            {
                sectionCount = 0;
                sectionIndex++;

                if (sectionIndex >= sections.Count)
                {
                    break;
                }

                nowSection = sections[sectionIndex];
            }

            if (nowSection.isShoot != false)
            {
                List<BulletPattern> patterns = nowSection.GetNowPatterns();
                for (int i = 0; i < patterns.Count; i++)
                {
                    BulletPattern pattern = patterns[i];
                    if (pattern.isShoot != false)
                    {
                        CreateBulletOnPattern(pattern, CreatePivots[pattern.createPivotIndex].position);
                    }
                }
            }

            //// Debug
            //Debug.Log("[" + sectionIndex + "]Interval: " + (intervalCount + 1));
            intervalCount++;
            // Debug end

            sectionCount++;

            yield return new WaitForSeconds(nowSection.interval);
        }

        Application.Quit();
    }

    public void CreateBulletOnPattern(BulletPattern pattern, Vector3 createPos)
    {
        GameObject creator;
        switch (pattern.bulletCreatorType)
        {
            case BulletCreatorType.NWay:
                pattern.bulletCreatorName = string.Format("Bullet Creator NWay");
                creator = ObjectMgr.Instance.SpawnFromPool(pattern.bulletCreatorName, createPos, Quaternion.identity);
                
                creator.GetComponent<BulletCreatorNWay>().Init(pattern, creator.transform.position);
                break;

            case BulletCreatorType.Circle:
                pattern.bulletCreatorName = string.Format("Bullet Creator NWay");
                pattern.minAngle = 0;
                pattern.maxAngle = 360f - (360f / pattern.bulletCount);
                creator = ObjectMgr.Instance.SpawnFromPool(pattern.bulletCreatorName, createPos, Quaternion.identity);
                creator.GetComponent<BulletCreatorNWay>().Init(pattern, createPos);
                break;

            default:
                break;
        }
    }

    public void CreateBulletsOnPattern()
    {
        if (patternsIndex >= patterns.Count)
            patternsIndex = 0;

        BulletPattern pattern = patterns[patternsIndex];
        if (isTest)
            pattern = PatternTest;

        Vector3 createPos = CreatePivots[pattern.createPivotIndex].position;
        if (isTest)
            createPos = TestCreatrPivot.transform.position;

        GameObject creator;
        switch (pattern.bulletCreatorType)
        {
            case BulletCreatorType.NWay:
                pattern.bulletCreatorName = string.Format("Bullet Creator NWay");
                creator = ObjectMgr.Instance.SpawnFromPool(pattern.bulletCreatorName, createPos, Quaternion.identity);
                creator.GetComponent<BulletCreatorNWay>().Init(pattern, creator.transform.position);
                break;

            case BulletCreatorType.Circle:
                pattern.bulletCreatorName = string.Format("Bullet Creator NWay");
                pattern.minAngle = 0;
                pattern.maxAngle = 360f - (360f / pattern.bulletCount);
                creator = ObjectMgr.Instance.SpawnFromPool(pattern.bulletCreatorName, createPos, Quaternion.identity);
                creator.GetComponent<BulletCreatorNWay>().Init(pattern, creator.transform.position);
                break;

            default:
                break;
        }
        //if (isTest == false)
        //    patternsIndex++;
    }
}
