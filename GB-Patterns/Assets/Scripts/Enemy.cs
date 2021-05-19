using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public float randomDir;

    public virtual void Move()
    {
        rb.velocity = new Vector2(randomDir, -moveSpeed);
    }

    public void RandomSpeed(float minmax)
    {
        randomDir = Random.Range(-minmax, minmax);
    }

    public void SetPhysicsMaterial()
    {
        
    }

}