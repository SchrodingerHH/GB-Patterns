using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleGun : GunController
{

    
    void Start()
    {
        middleShootPos = GameObject.Find("MiddleShootPos");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack(middleShootPos);
        }   
    }

    
}
