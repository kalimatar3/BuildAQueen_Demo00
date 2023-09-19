using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class LoadNeckModel : LoadNeck
{
    protected override void LoadPath()
    {
        base.LoadPath();
       path = path + "Models/";
    }
}
