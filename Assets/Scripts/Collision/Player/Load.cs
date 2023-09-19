using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Load : MyBehaviour
{
    [SerializeField] protected List<Transform> ListCanLoad;
    [SerializeField] protected List<String> ListCanLoadName;
    protected abstract bool CanLoad(string Name);
    public virtual void load(String Name)
    {
        if(!CanLoad(Name)) return;
        this.Loading();
    }
    protected virtual void Loading()
    {
       //  override
    }
}
