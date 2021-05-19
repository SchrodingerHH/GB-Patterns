using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : Enemy
{

    private void Start()
    {
        moveSpeed = 2;
    }

    void Update()
    {
        Move();
    }
    
}
