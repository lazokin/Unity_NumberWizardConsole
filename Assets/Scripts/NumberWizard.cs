using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    void Start ()
    {
        Debug.Log("Weclome to Number Wizard!");
        Debug.Log("Pick a number. Don't tell me what it is.");
        Debug.Log("The highest number you can pick is " + max + ".");
        Debug.Log("The lowest number you can pick is " + min + ".");
        Debug.Log("Tell me if you number is higher or lower than " + guess + ".");
        Debug.Log("Up Arrow for higher. Down Arrow for lower. Enter for correct guess.");
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("You pushed the Up Arrow.");
            min = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("You pushed the Down Arrow.");
            max = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You pushed Enter.");
        }
    }
}
