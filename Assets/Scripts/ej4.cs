﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        int res = num1 + num2;
        Debug.Log("La suma entre " + num1 +" y " + num2 +" da como resultado " + res);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
