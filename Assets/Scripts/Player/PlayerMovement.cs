using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MyBehaviour
{
    [SerializeField] protected PlayerController playerController;
    [SerializeField] protected float MoveSpeed;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadplayerController();
    }
    protected void LoadplayerController()
    {
        playerController = GetComponentInParent<PlayerController>();
    }
    [SerializeField] protected Vector3 MousePos;
    protected void Movement()
    {
        Rigidbody mybody = playerController.GetComponent<Rigidbody>();
        if(mybody == null) 
        {
            Debug.LogWarning(this.transform.parent + "cant found rid");
            return;
        }
        mybody.velocity = new Vector3(mybody.velocity.x,mybody.velocity.y,MoveSpeed);
        this.MousePos = InputManager.Instance.MousePos;
        this.transform.parent.position = new Vector3(this.MousePos.x,this.transform.parent.position.y,this.transform.parent.position.z);
    }
    protected void FixedUpdate()
    {
        this.Movement();
    }
}
