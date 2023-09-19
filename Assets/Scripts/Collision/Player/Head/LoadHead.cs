using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadHead : PlayerLoader
{
    protected override void LoadPath()
    {
        base.LoadPath();
        path = path + "Head/";
    }
}
