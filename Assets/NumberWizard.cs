using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    int min;
    int max;
    int guess;

    public int maxGuessesAllowed = 5;

    

    public Text text;


	// Use this for initialization
	void Start () {
        StartGame();
	}

    void StartGame()
    {
        min = 1;
        max = 1000;
        NextGuess(); //ovo se zove da se pocetni broj odmah promijeni na pocetku da nebu uvijek 500 


        //max = max + 1;

        //print("========================");
        //print("Welcome to Number Wizard"); //ispisuje na konzolu
        //print("Pick a number in your head");

        //print("The highest number you can pick is " + max);
        //print("The lowest number you can pick is " + min);

        //print("Is the number higher or lower than " + guess + "?");
        //print("Up = higher, down = lower, return = equal");


    }


    void NextGuess()
    {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max+1);
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if(maxGuessesAllowed <= 0)
        {
            Application.LoadLevel("Win");  // ucitavamo drugu scenu
        }
        //print("Higer or lower than " + guess);
        //print("Up = higher, down = lower, return = equal");
    }	

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }


    public void GuesslLower()
    {
        max = guess;
        NextGuess();
    }
}
