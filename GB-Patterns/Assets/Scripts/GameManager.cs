using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    

    void Start()
    {
        Enemy.createAsteroidEnemy(getRandomPos());
    }

    
    void Update()
    {
        
    }


    Vector2 getRandomPos()
    {
        Vector3 boundsR = Camera.main.ViewportToWorldPoint(new Vector3(0,0,Camera.main.nearClipPlane));
        Vector3 boundsL = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, Camera.main.nearClipPlane));
        Vector2 randomPos = new Vector2(Random.Range(boundsL.x, boundsR.x), Random.Range(boundsL.y, boundsR.y));

        return randomPos;
    }
}
