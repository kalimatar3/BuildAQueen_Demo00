using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReciver : DameReciver
{
    [SerializeField] protected PlayerController playerController;
    public PlayerController PlayerController  => playerController;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadplayerControler();
    }
    protected void LoadplayerControler()
    {
        playerController = GetComponentInParent<PlayerController>();
    }
}
