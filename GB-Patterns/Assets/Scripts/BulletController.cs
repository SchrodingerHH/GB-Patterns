using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Rigidbody rb;


    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    private void OnEnable()
    {
        rb.AddForce(transform.up*100,ForceMode.Acceleration);
        StartCoroutine(poolReturn(3f));
    }

    IEnumerator poolReturn(float time)
    {
        PlayerController.bullets.Remove(gameObject);
        yield return new WaitForSeconds(time);
        PlayerController.disabledBullets.Add(gameObject);
        gameObject.SetActive(false);
    }

}
