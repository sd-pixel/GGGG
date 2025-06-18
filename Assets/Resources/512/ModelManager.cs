using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager 
{
   
    private static ModelManager instance;
    
    Dictionary<string,ModelBace> dic=new Dictionary<string,ModelBace>();
   
    public static ModelManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ModelManager();
            }
            return instance;
        }
    }
    public ModelBace GetModel<T>()where T : ModelBace
    {
        Type type = typeof(T);

        if (dic.ContainsKey(type.ToString()))
        {
            return dic[type.ToString()];
        }
        else
        {
            ModelBace model = Activator.CreateInstance(type)as ModelBace ;
            model.Init();

            dic.Add(type.ToString(), model);
            return model;
        }


    }
}
