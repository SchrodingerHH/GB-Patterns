using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Service : IService
{
    public void Test()
    {
        Debug.Log(nameof(Service));
    }
}
