using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerLoader : Load
{
    [SerializeField] protected string path;
    protected override bool CanLoad(string Name)
    {
        foreach(Transform element in ListCanLoad)
        {
            if(element.name  == Name  ) return true;
        }
        Debug.Log(this.transform + "Dont Have this Model"); 
        return false;
    }
    public override void load(string Name)
    {
        base.load(Name);
        this.ActivebyName(Name);
    }
    public virtual void ActivebyName(string Name)
    {
        foreach(Transform element in ListCanLoad)
        {
            element.gameObject.SetActive(false); 
            if(Name == element.name)
            {
                element.gameObject.SetActive(true);
            }
        }
    }
    protected override void Reset()
    {
        base.Reset();
        this.LoadPath();
    }
    protected override void Start()
    {
        base.Start();
        this.LoadListCanLoadName();
        this.LoadListCanLoad();
    }
    protected virtual void LoadPath()
    {
       path = path + "PlayerModels/";
    }
    protected void LoadListCanLoadName()
    {
        for(int i = 0 ;  i < MapManager.Instance.ListBodyParts.Count; i ++)
        {
            if(MapManager.Instance.ListBodyParts[i].Name == this.transform.parent.name)
            {
                for(int j = 0 ;  j < MapManager.Instance.ListBodyParts[i].ListParts.Count; j++)
                {
                    if(this.transform.name == MapManager.Instance.ListBodyParts[i].ListParts[j].Name)
                    {
                        for(int k = 0 ; k < MapManager.Instance.ListBodyParts[i].ListParts[j].ListThings.Count; k++ )
                        {
                            ListCanLoadName.Add(MapManager.Instance.ListBodyParts[i].ListParts[j].ListThings[k]);
                        }
                    }
                }
            }
        }
    }
    protected void LoadListCanLoad()
    {
        if(ListCanLoad.Count > 0) return;
        StartCoroutine(this.LoadListCanLoadDelay());
    }
    protected IEnumerator LoadListCanLoadDelay()
    {
        yield return new WaitUntil(predicate:()=>
        {
            if(ListCanLoadName.Count < 0) return false;
            else return true;
        });
        foreach(String element in ListCanLoadName)
        {
            Transform newPre = Instantiate(Resources.Load<Transform>(path + element),this.transform);
            newPre.gameObject.SetActive(false);
            ListCanLoad.Add(newPre);
            newPre.name = element;
        }
    }
}
