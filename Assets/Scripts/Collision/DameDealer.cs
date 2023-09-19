using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider),typeof(Rigidbody))]
public class DameDealer : MyBehaviour
{
    protected virtual void ImpactToObj(Transform obj)
    {
        Debug.Log(obj.transform.parent.ToString() + "is impacted by" + this.transform.parent.ToString());
    }
    protected virtual void OnTriggerEnter(Collider other)
    {
        this.ImpactToObj(other.transform); 
    }
} 
