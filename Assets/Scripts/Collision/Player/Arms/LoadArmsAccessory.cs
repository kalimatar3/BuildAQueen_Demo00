using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadArmsAccessory : LoadArms
{
    protected override void LoadPath()
    {
        base.LoadPath();
        path = path + "Accessories/";
    }

}
