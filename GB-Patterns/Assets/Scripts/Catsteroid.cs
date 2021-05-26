using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catsteroid : Enemy
{
    public List<LineRenderer> lnRenderers;
    public Transform playerTransform;
    List<Vector3> pCoords = new List<Vector3>();

    private void Awake()
    {
        playerTransform = GameObject.Find("Player").transform;
    }

    void Start()
    {
        moveSpeed = 3.5f;
        if (Random.value>=0.5)
        {
            RandomSpeed(0.5f,moveSpeed);
        }
        else
        {
            RandomSpeed(-moveSpeed,-0.5f);
        }
        Move();
    }

    void Update()
    {
        getPlayerCoord();
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
        foreach (LineRenderer ln in lnRenderers)
        {
            ln.positionCount = 2;
            ln.SetPosition(0, ln.transform.position);
            ln.SetPosition(1, pCoords[0]);
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
