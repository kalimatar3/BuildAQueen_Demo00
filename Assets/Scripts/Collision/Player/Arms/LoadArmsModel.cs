using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadArmsModel : LoadArms
{
    protected override void LoadPath()
    {
        base.LoadPath();
        path = path + "/Models";
    }
}
