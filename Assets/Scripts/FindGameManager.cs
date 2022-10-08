using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FindGameManager : MonoBehaviour
{
    AudioManager audioManager;
    public Text scoreText;

    int points = 0;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        scoreText = FindObjectOfType<Text>();
    }

    public void GetPoints(int aux)
    {
        points += aux;
        scoreText.text = "Pontos: " + points;
        //Debug.Log(count);
        if (points == 15)
        {
            Debug.Log("Encontrou todos os erros!!!");
            audioManager.Play("Win");
        }        
    }
}
