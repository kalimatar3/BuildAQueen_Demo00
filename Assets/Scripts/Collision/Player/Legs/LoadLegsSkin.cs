using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLegsSkin : LoadLegs
{
    protected override void LoadPath()
    {
        base.LoadPath();
       path = path + "Skins/";
    }
}
