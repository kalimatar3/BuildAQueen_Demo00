using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LoadHeadModel : LoadHead
{
    protected override void LoadPath()
    {
        base.LoadPath();
       path = path + "Models/";
    }
}
