﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    public GameObject prefabPlayer;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Instantiate(prefabPlayer, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
