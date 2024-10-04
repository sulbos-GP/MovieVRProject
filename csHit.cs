using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("!!");
        if (other.tag=="Bullet")
        {
            Destroy(gameObject);
        }
    }
}
