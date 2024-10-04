using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Count : MonoBehaviour
{
    public GameObject buttonCheck;
    public int buttonList=0;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = buttonCheck.transform.childCount;

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < count; i++)
        {
            if (buttonCheck.transform.GetChild(i).GetComponent<csButton>().buttonOn)
            {
                buttonList++;
            }
        }
        if (buttonList >= 4)
        {
            Debug.Log("!!!!!!!!!");
            gameObject.GetComponent<Button_Count>().enabled = false;
        }
        buttonList = 0;
    }
}
