using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MyBehaviour
{
    protected static CameraController instance;
    public static CameraController Instance { get => instance;}
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
