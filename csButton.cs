using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.Interactions.Interactables;
using VRTK.Prefabs.Interactions.Interactors;

public class csButton : MonoBehaviour
{
    public GameObject g;
    public GameObject spawnObject;
    public Transform spawn;
    public bool buttonOn = false;
    public bool isinter;
    public void inter(InteractorFacade f)
    {
        isinter = true;
    }
    public void uninter(InteractorFacade f)
    {
        isinter = false;
    }
    public void inter(InteractableFacade f)
    {
        isinter = true;
    }
    public void uninter(InteractableFacade f)
    {
        isinter = false;
    }
    public void Click(bool b)
    {
        if (isinter)
        {
            g.GetComponent<Renderer>().material.color = Color.blue;
            Instantiate(spawnObject, spawn.position, Quaternion.identity);
        }
    }
}
