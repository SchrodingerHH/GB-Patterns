using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IHit
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public float randomDir;

    public event System.Action<float> OnHitChange = delegate(float f) { };

    public virtual void Move()
    {
        rb.velocity = new Vector2(randomDir, -moveSpeed);
    }

    public virtual void RandomSpeed(params float[] param)
    {
        randomDir = Random.Range(-param[0], param[1]);
    }

    public static Asteroid createAsteroidEnemy(Vector2 coords)
    {
        var enemy = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid/Asteroid1"),new Vector3(coords.x,coords.y,0),Quaternion.identity);
        Debug.Log("enemy instantiated");
        return enemy;
    }

    public static Catsteroid createCatsteroidEnemy(Vector2 coords)
    {
        var enemy = Instantiate(Resources.Load<Catsteroid>("Enemy/Asteroid"));

        return enemy;
    }

    public void Hit(float damage)
    {
        OnHitChange.Invoke(damage);
    }
}