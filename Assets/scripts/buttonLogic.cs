using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonLogic : MonoBehaviour
{
    public GameObject first;
    public GameObject second;
    public GameObject third;
    public static int counter = 0;

    public void ButtonPressed() {
        if (counter == 0) 
        {
            Debug.Log("first");
            first.SetActive(true);
            counter++;
        }
        else if (counter == 1)
        {
            Debug.Log("second");
            second.SetActive(true);
            counter++;
        }
        else if (counter > 1) 
        {
            third.SetActive(true);
        }

    } 
}
