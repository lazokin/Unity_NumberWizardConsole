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
        Debug.Log("Think of a number between " + min + " and " + max + " inclusive.");
        Debug.Log("Don't tell me what it is. I'll try to guess it.");
        Debug.Log("Press the Up Arrow for higher, the Down Arrow for lower, or Enter if I guessed correctly.");
        Debug.Log("Is your number " + guess + "?");
        max = max + 1;
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Nope. Higher than " + guess + ".");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your number " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Nope. Lower than " + guess + ".");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your number " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Yep! My number was " + guess + ".");
        }
    }
}
