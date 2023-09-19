using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNeckSkin : LoadNeck
{
    protected override void LoadPath()
    {
        base.LoadPath();
       path = path + "Skins/";
    }
}
