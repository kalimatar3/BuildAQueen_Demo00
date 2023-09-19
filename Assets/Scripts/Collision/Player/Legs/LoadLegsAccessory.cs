using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LoadLegsAccessory : LoadLegs
{
    protected override void LoadPath()
    {
        base.LoadPath();
        path = path + "Accessories/";
    }
}
