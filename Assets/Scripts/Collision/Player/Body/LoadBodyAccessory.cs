using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LoadBodyAccessory : LoadBody
{
    protected override void LoadPath()
    {
        base.LoadPath();
        path = path + "Accessories/";
    }
}
