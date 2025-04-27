using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examplescipts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string name = "Marc";
        if (name == "James")
        {
            Debug.Log("My name is James");
        }
        else if (name == "Marc")
        {
            Debug.Log("My name is Marc");
        }
        else
        {
            Debug.Log("I don't recognize that name");
        }

        switch(name)
        {
            case "James": Debug.Log("My name is James"); break;
            case "Marc": Debug.Log("My name is Marc"); break;
            default: Debug.Log("I don't recognize that name"); break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
