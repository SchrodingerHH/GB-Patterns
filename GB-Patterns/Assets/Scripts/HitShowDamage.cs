using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitShowDamage : MonoBehaviour
{
    public void Add(IHit value)
    {
        value.OnHitChange += ValueOnHitChange;
    }

    public void Remove(IHit value)
    {
        value.OnHitChange -= ValueOnHitChange;
    }

    private void ValueOnHitChange(float damage)
    {
        Debug.Log(damage);
    }
}
