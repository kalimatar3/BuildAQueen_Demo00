using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class LoadLegsModel : LoadLegs
{
    protected override void LoadPath()
    {
        base.LoadPath();
       path = path + "Models/";
    }
}
