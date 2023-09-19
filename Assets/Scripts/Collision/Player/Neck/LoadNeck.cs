using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LoadNeck : PlayerLoader
{
    protected override void LoadPath()
    {
        base.LoadPath();
       path = path + "Neck/";
    }
}
