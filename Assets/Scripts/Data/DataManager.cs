using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MyBehaviour
{
    protected static DataManager instance;
    public static DataManager Instance { get => instance;}
    public List<String> AllBodyPartName;
    public List<String> AllPartthingName;
    public List<String> AllStyleName;
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
