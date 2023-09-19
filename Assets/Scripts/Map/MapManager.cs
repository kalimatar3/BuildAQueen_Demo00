using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MapManager : MyBehaviour
{
    [Serializable][SerializeField]
    public class bodyParts
    {
        [Serializable]
        public  class TypePart
        {
            public string Name;
            public List<String> ListThings;
        }
        public string Name;
        public List<TypePart> ListParts;
    }
    public List<bodyParts> ListBodyParts;
    protected static MapManager instance;
    public static MapManager Instance { get => instance;}
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
