using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadArmsSkin : LoadArms
{    
    protected override void LoadPath()
    {
        base.LoadPath();
        path = path + "Skins/";
    }
}
