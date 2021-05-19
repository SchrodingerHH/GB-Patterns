using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catsteroid : Enemy
{
    void Start()
    {
        moveSpeed = 3.5f;
        RandomSpeed(moveSpeed);
        Move();
    }

    void Update()
    {
        
    }

    public override void Move()
    {
        Debug.Log("!");
        rb.AddForce(new Vector2(randomDir, moveSpeed), ForceMode2D.Impulse);
    }


}
