﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScripts2 : MonoBehaviour
{
    public enum Ename
    {
        Jen,
        Marc,
        Jose,
        Jessica
    }

    public Ename name = Ename.Jen;

    public string str_name;
    // Start is called before the first frame update
    void Start()
    {
        switch(name)
        {
            case Ename.Jen: Debug.Log("My name is Jen"); break;
            case Ename.Marc: Debug.Log("My name is Marc"); break;
            case Ename.Jose: Debug.Log("My name is Jose"); break;
            case Ename.Jessica: Debug.Log("My name is Jessica"); break;
            default: Debug.Log("My name is something"); break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
