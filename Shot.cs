using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.Interactions.Interactables;

public class Shot : MonoBehaviour
{
    public bool isGunGrab;
    public GameObject bullet;
    public GameObject gunPoint;
    public void evtGrab(InteractableFacade f)
    {
        isGunGrab = true;
        Debug.Log(isGunGrab);
    }
    public void evtUnGrab(InteractableFacade f)
    {
        isGunGrab = false;
        Debug.Log(isGunGrab);
    }
    public void evtFire(bool v)
    {
        if (isGunGrab)
        {
            GameObject obj = Instantiate(bullet, gunPoint.transform.position,
            gunPoint.transform.rotation);
            obj.GetComponent<AudioSource>().Play();
            obj.GetComponent<Rigidbody>().AddForce(gunPoint.transform.forward * 50,
            ForceMode.Impulse);
            obj.GetComponent<Rigidbody>().AddForce(gunPoint.transform.up *3.0f, ForceMode.Impulse);
            Destroy(obj, 5);
        }
    }

}
