using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LoadBodyModel : LoadBody
{
    protected override void LoadPath()
    {
        base.LoadPath();
        path = path + "Models/";
    }
}
