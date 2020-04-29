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
        CalculateNewGuess();
        high = high + 1;
    }

    public void OnPressHigher()
    {
        low = guess + 1;
        if (low >= 1000)
        {
            low = 1000;
        }
        CalculateNewGuess();
    }

    public void OnPressLower()
    {
        high = guess - 1;
        if (high <= 0)
        {
            high = 1;
        }
        CalculateNewGuess();
    }

    void CalculateNewGuess() 
    {
        guess = Random.Range(low, high);
        guessText.text = guess.ToString();
    }


}
