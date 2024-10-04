using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject[] g;

    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        g = GameObject.FindGameObjectsWithTag("Object");
        for (int i = 0; i < g.Length; i++)
        {
            if (Mathf.Abs(g[i].transform.position.x - gameObject.transform.position.x)<4)
            {
                if (Mathf.Abs(g[i].transform.position.y - gameObject.transform.position.y) < 4)
                {
                    if (Mathf.Abs(g[i].transform.position.z - gameObject.transform.position.z) < 4)
                    {
                        g[i].GetComponent<Renderer>().material.color = Color.blue;
                    }
                    else
                    {
                        g[i].GetComponent<Renderer>().material.color = Color.white;
                    }
                }
                else
                {
                    g[i].GetComponent<Renderer>().material.color = Color.white;
                }
            }
            else
            {
                g[i].GetComponent<Renderer>().material.color = Color.white;
            }
        }
    }
}
