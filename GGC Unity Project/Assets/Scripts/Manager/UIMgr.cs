using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    public Action Click;

    void ClickEvent()
    {
        Click();
    }
}
