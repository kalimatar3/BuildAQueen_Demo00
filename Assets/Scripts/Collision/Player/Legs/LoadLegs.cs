using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LoadLegs : PlayerLoader
{
    protected override void LoadPath()
    {
        base.LoadPath();
       path = path + "Legs/";
    }
}
