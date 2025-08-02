using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessGame : MonoBehaviour
{
    public int min = 0, max = 1000;//we made these public so that the user get the options in the unity ui/access to these variables
    int guess;//this is not public because this is the user specific and does not need to be public 
    // Start is called before the first frame update
    void Start()
    {
        guess = (min + max) / 2;
        Debug.Log("Welcome to the Guess Game. Think of a number between 0 to 1000 and Don't tell me the number.");
        Debug.Log("My guess is:" + guess);//this is going to append/show our guess in the console by printing
    }

    // Update is called once per frame
    void Update()
    {
        //this game asks the user to think of a number then it starts guessing but it also uses the user's input like arrow down(real number is smaller than the number guessed), up and equal to(guessing correctly)
        if (Input.GetKeyDown(KeyCode.UpArrow))//using the GetKeyDown beacuse this is gonna be true for only one frame means we want the user to press any key once and then show our guess and then game further 
        {
            min = guess;
            guess = (min + max) / 2;
            Debug.Log("So your number is higher, i guess to be:" + guess);//basically upArrow tells that the number is higher than the number guessed and behind the scenes it is binary search which now declares the guess to the min to leave behind all the numbers in the previous guess(means last guess se bada number hi dena ab guesses me so min to be the last guess value)
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (min + max) / 2;
            Debug.Log("So your number is lower, i guess to be:" + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Equals))
        {
            Debug.Log("I guessed the number. It was quite easy. Better luck next time hiding it from me.");
        }
    }
}
