﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desotry : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q)){

          Destroy(gameObject);
        }
    }
}
