using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerController : MyBehaviour
{
    protected static PlayerController instance;
    public static PlayerController Instance { get => instance;}
    [SerializeField] protected PlayerMovement playerMovement;
    public PlayerMovement PlayerMovement => playerMovement;
    [SerializeField] protected ModelManager modelManager;
    public ModelManager ModelManager => modelManager;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerMovement();
        this.LoadModelManager();
    }
    protected void LoadPlayerMovement()
    {
        playerMovement = GetComponentInChildren<PlayerMovement>();
        if(playerMovement == null)
        {
            Debug.LogWarning(this.transform + "Cant found playermovement");
        }
    } 
    protected void LoadModelManager()
    {
        modelManager = GetComponentInChildren<ModelManager>();
        if(modelManager == null)
        {
            Debug.LogWarning(this.transform + "Cant found ModelManager");
        }
    } 
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
