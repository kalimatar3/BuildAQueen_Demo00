using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadHeadAccessory : LoadHead
{
    protected override void LoadPath()
    {
        base.LoadPath();
        path = path + "Accessories/";
    }

}
