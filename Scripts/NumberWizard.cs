using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int high;
    [SerializeField] int low;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        guess = (low + high) / 2;
        guessText.text = guess.ToString();
        high = high + 1;
    }

    public void OnPressHigher()
    {
        low = guess;
        CalculateNewGuess();
    }

    public void OnPressLower()
    {
        high = guess;
        CalculateNewGuess();
    }

    void CalculateNewGuess() 
    {
        guess = (low + high) / 2;
        guessText.text = guess.ToString();
    }


}
