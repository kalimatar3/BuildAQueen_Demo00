using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBodySkin : LoadBody
{    
    protected override void LoadPath()
    {
        base.LoadPath();
        path = path + "Skins/";
    }
}
