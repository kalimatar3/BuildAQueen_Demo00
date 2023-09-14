using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBehaviourScript : MonoBehaviour
{
    protected virtual void LoadComponents()
    {
        //override;
    }
    protected virtual void Reset()
    {
        this.LoadComponents();
    }
    protected virtual void Awake()
    {
        this.LoadComponents();
    }
    protected virtual void Start()
    {
        //override
    }
}
