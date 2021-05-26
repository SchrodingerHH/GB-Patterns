using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDictinary : MonoBehaviour
{
    private Dictionary<string, string> keyValuePairs = new Dictionary<string, string> {
        {"a","a"},{"b","b"},{"c","c"}
    };

    void Start()
    {
        AddObjectToD();
    }

    void Update()
    {
        
    }

    void AddObjectToD()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i<enemies.Length; i++)
        {
            //keyValuePairs.Add("a", enemies[i].name);
            keyValuePairs["a"] = enemies[i].name;
            Debug.Log(keyValuePairs["a"]);
        }


    }
}
