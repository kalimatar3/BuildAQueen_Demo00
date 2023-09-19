using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEditor.Experimental.GraphView;
public class InputManager : MyBehaviour
{
    protected static InputManager instance;
    public static InputManager Instance { get => instance;}
    public Vector3 TouchPos;
    public Vector3 MousePos;
    public bool Touched;
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
    protected void GetTouchPos()
    {
        if(Input.touchCount > 0)
        {
            Touch thistouch = Input.GetTouch(0);
            TouchPos = Camera.main.ScreenToWorldPoint(thistouch.position);
        }
        else
        {
            TouchPos = Vector3.zero;
        }
    }
    protected void GetMousePos()
    {
        Touched = Input.GetMouseButton(0);
        if(Input.GetMouseButton(0))
        {
            Vector3 cache = Input.mousePosition;
            cache.z = Camera.main.nearClipPlane + (PlayerController.Instance.transform.position - CameraController.Instance.transform.position).magnitude ;
            MousePos = Camera.main.ScreenToWorldPoint(cache);
        }
        else
        {
            MousePos = Vector3.zero;
        }
    }
    protected void FixedUpdate()
    {
        this.GetTouchPos();
        this.GetMousePos();
    }
}
