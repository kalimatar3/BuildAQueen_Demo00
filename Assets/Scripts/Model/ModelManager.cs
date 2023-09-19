using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager : MyBehaviour
{
    protected static ModelManager instance;
    public static ModelManager Instance { get => instance;}
    protected override void Awake()
    {
        base.Awake();
        if(instance != null && instance != this)
        {
            Destroy(this);
            Debug.LogWarning(this.gameObject + "Does Existed");
        }
        else instance = this;
    }

}
