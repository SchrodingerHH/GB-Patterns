using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public static List<GameObject> bullets;

    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            GameObject cBullet = Instantiate(bulletPrefab,transform.position,Quaternion.identity);
            bullets.Add(cBullet);
            cBullet.SetActive(false);
        }
    }


    void Update()
    {
        
    }
}
