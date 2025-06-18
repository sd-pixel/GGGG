using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public enum UIType
{
    Fixed,
    Normal,
    Tip
}

public class UIBace 
{
    public string path;

    public GameObject go;
    
    public UIType uiType;
    public UIBace(string path,UIType uiType)
    {
        this.path = path;
        this.uiType = uiType;
    }

    public virtual void Init(GameObject go)
    {
        this.go = go;
    }

    public void Destroy()
    {
        GameObject.Destroy(go);
    }

}
