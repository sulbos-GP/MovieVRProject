using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csLook : MonoBehaviour
{
    public Camera c;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(c.transform);
        transform.Rotate(0, 180, 0);
        float d = Vector3.Distance(
        c.transform.position, transform.position);
        transform.localScale = Vector3.one * d * 0.005f;
        print(d);
    }
}
