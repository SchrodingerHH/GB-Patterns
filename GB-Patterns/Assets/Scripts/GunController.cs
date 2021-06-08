using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject middleShootPos;
    public GameObject rightShootPos;
    public GameObject leftShootPos;



    void Start()
    {
        //middleShootPos = GameObject.Find("MiddleShootPos");
        //rightShootPos = GameObject.Find("RightShootPos");
        //leftShootPos = GameObject.Find("LeftShootPos");
    }

    void Update()
    {
        
    }

    public virtual void Attack(params GameObject[] shootPoints)
    {
        for (int i = 0; i < shootPoints.Length; i++)
        {
            PlayerController.bullets[i].transform.position = shootPoints[i].transform.position;
            PlayerController.bullets[i].transform.rotation = shootPoints[i].transform.rotation;
            PlayerController.bullets[i].SetActive(true);
        }
    }


}
