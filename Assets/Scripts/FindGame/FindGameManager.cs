using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FindGameManager : MonoBehaviour
{
    AudioManager audioManager;
    public Text scoreText;

    public int errosNoDesenho = 0;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        scoreText = FindObjectOfType<Text>();
    }

    public void GetPoints(int errosEcontrados)
    {
        errosNoDesenho = errosNoDesenho -  errosEcontrados;
        scoreText.text = "     Erros a serem encontrados: " + errosNoDesenho;
        //Debug.Log(count);
        if (errosNoDesenho == 0)
        {
            Debug.Log("Encontrou todos os erros!!!");
            scoreText.text = "   Parabéns! você encontrou todos os erros!";
            audioManager.Play("Win");
            GameManager.Instace.ShowEndingDialog();
        }        
    }
}
