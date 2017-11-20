using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alive : MonoBehaviour {

    public bool alife = false;


    void Update()
    {
        if (alife)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        else if (!alife)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
