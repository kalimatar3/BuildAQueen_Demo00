using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GateDealer : DameDealer
{
    [SerializeField] protected List<Transform> test;
    public DataManager dataManager;
    [Dropdown("dataManager.AllBodyPartName")]
    [SerializeField] protected string BodyPart;
    [Dropdown("dataManager.AllPartthingName")]
    [SerializeField] protected string TypePart;
    [Dropdown("dataManager.AllStyleName")]
    [SerializeField] protected string Style;
    protected void LoadModelNameToManager(string Name)
    {
        foreach(String element in GetPartthingByName(TypePart))
        {
            if(Name == element)
            {
                return;
            }
        }
        GetPartthingByName(TypePart).Add(Name);
    }
    protected List<String> GetPartthingByName(string Name)
    {
        foreach(MapManager.bodyParts.TypePart element in GetBodyPartByname(BodyPart))
        {
            if(Name == element.Name)
            {
                return element.ListThings;
            }
        }
        Debug.LogWarning(MapManager.Instance.transform + "dont have" + Name  + " Partthing");
        return null;
    }
    protected List<MapManager.bodyParts.TypePart> GetBodyPartByname(string Name)
    {
        foreach(MapManager.bodyParts element in MapManager.Instance.ListBodyParts)
        {
            if(Name == element.Name)
            {
                return element.ListParts;
            }
        }
        Debug.LogWarning(MapManager.Instance.transform + "dont have" + Name  + " bodypart");
        return null;
    }
    protected override void ImpactToObj(Transform obj)
    {
        PlayerReciver playerReciver = obj.GetComponent<PlayerReciver>();
        if(playerReciver == null) return;
        test.Add(playerReciver.PlayerController.ModelManager.transform.Find(BodyPart));
        test.Add(playerReciver.PlayerController.ModelManager.transform.Find(BodyPart).transform.Find(TypePart));
        playerReciver.PlayerController.ModelManager.transform.Find(BodyPart).transform.Find(TypePart).GetComponent<PlayerLoader>().ActivebyName(Style);
    }
    protected override void Start()
    {
        base.Start();
        this.LoadModelNameToManager(Style);
    }
}
