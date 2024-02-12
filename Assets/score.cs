using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public TextMeshProUGUI winText;
    int dollar = 100;
    // Start is called before the first frame update
    void Start()
    {
        if (buttonLogic.counter == 1) {
            dollar = 75;
        }
        else if (buttonLogic.counter == 2) {
            dollar = 50;
        }
        winText.text = "You win!, you profit is - " + dollar + " dollar";  
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
