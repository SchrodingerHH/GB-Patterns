using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    private void OnEnable()
    {
        rb.AddForce(Vector3.up,ForceMode.Acceleration);
        StartCoroutine(poolReturn(3f));
    }

    IEnumerator poolReturn(float time)
    {
        PlayerController.bullets.Remove(gameObject);
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
    }

}
