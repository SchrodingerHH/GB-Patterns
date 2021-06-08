using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catsteroid : Enemy
{
    public List<LineRenderer> lnRenderers;
    public Transform playerTransform;
    private float smoothSpeed = 0.015f;
    List<Vector3> pCoords = new List<Vector3>();
    private Vector3 smoothedPosition;

    private Vector3 smoothVelocity = Vector3.zero;

    private void Awake()
    {
        playerTransform = GameObject.Find("Player").transform;
    }

    void Start()
    {
        moveSpeed = 3.5f;
        if (Random.value >= 0.5)
        {
            RandomSpeed(0.5f, moveSpeed);
        }
        else
        {
            RandomSpeed(-moveSpeed, -0.5f);
        }
        Move();
    }

    void Update()
    {
        Vector3 desiredPosition = playerTransform.position + new Vector3(3,2,0);
        //smoothedPosition = Vector3.Lerp(desiredPosition, playerTransform.position, smoothSpeed);
        
        smoothedPosition = Vector3.SmoothDamp(desiredPosition, playerTransform.position, ref smoothVelocity, 0.015f);

    //getPlayerCoord();
    lasersTarget();
    }
    

    public override void RandomSpeed(params float[] param)
    {
        randomDir = Random.Range(param[0], param[1]);
    }

    public override void Move()
    {
        Debug.Log("!");
        rb.AddForce(new Vector2(randomDir, moveSpeed), ForceMode2D.Impulse);
    }

    private void lasersTarget()
    {
        /*foreach (LineRenderer ln in lnRenderers)
        {
            ln.positionCount = 2;
            ln.SetPosition(0, ln.transform.position);
            ln.SetPosition(1, pCoords[0]);
        }*/
        foreach (LineRenderer ln in lnRenderers)
        {
            ln.positionCount = 2;
            ln.SetPosition(0,ln.transform.position);
            ln.SetPosition(1, smoothedPosition);
        }
    }

    private void getPlayerCoord()
    {
        pCoords.Add(playerTransform.position);

        if (pCoords.Count==100)
        {
            pCoords.RemoveAt(0);
        }
    }
}
