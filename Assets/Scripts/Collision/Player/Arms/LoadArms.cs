using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadArms : PlayerLoader
{
    protected override void LoadPath()
    {
        base.LoadPath();
        path = path + "/Arms";
    }
}
