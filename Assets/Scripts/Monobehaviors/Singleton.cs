using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : Component
{
    //Store an instance of the object as a static field to prevent multiple objects having their own instance
    private static T instance;

    //Field that allows access to instance
    public static T Instance
    {
        get
        {
            //Creates an instance if one does not exist when it is called
            if (instance == null)
            {
                instance = FindFirstObjectByType<T>();
                if (instance == null)
                {
                    GameObject obj = new()
                    {
                        name = typeof(T).Name
                    };
                    instance = obj.AddComponent<T>();
                }
            }
            return instance;
        }
    }

    //Always called as soon as instantiaton of the object is completed, will automatically destroy any duplicates
    public virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
