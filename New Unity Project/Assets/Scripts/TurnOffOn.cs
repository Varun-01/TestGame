using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffOn : MonoBehaviour
{
    public bool Light = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("x"))
        {
            Light = !Light;
        }

        if (Light == true)
            this.GetComponent<Light>().enabled = true;
        if (Light == false)
            this.GetComponent<Light>().enabled = false;
    }
}