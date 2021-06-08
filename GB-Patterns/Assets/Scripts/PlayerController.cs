using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public static List<GameObject> bullets = new List<GameObject>();
    public static List<GameObject> disabledBullets = new List<GameObject>();
    private Rigidbody2D rb;
    public float speedMult;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        for (int i = 0; i < 30; i++)
        {
            GameObject cBullet = Instantiate(bulletPrefab,transform.position,Quaternion.identity);
            bullets.Add(cBullet);
            cBullet.SetActive(false);
        }
        Debug.Log(bullets.Count);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            foreach (GameObject bullet in disabledBullets)
            {
                bullets.Add(bullet);
            }
            disabledBullets.Clear();
            Debug.Log(bullets.Count);
        }


        /*if (Input.GetKeyDown(KeyCode.Space) && bullets.Count!=0)
        {
            bullets[0].SetActive(true);
        }*/
    }

    private void FixedUpdate()
    {
        RBMove(speedMult);
        RotateToCursor();
    }

    void RotateToCursor()
    {
        Vector3 mousePosLocal = Input.mousePosition;
        Vector3 mousePosGlobal = Camera.main.ScreenToWorldPoint(mousePosLocal);
        Vector3 ViewVector = mousePosGlobal - transform.position;

        float targetAngle = Vector2.SignedAngle(Vector3.up, ViewVector);

        transform.rotation = Quaternion.Euler(0, 0, targetAngle);
    }

    void RBMove(float speed)
    {
        Vector2 moveAxis = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;

        rb.velocity = moveAxis*speed;
    }
}
