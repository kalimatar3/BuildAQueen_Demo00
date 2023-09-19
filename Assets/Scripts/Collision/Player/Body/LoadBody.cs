using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBody : PlayerLoader
{
    protected override void LoadPath()
    {
        base.LoadPath();
        path = path + "Body/";
    }
}
