using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public interface IHit
{
    event Action<float> OnHitChange;
    void Hit(float damage);
}
