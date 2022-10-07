using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameManager : MonoBehaviour
{
    AudioManager audioManager;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    int count = 14;
    public void EndGame(int aux)
    {
        count -= aux;
        Debug.Log(count);
        if (count == 0)
        {
            Debug.Log("Encontrou todos os erros!!!");
            audioManager.Play("Win");
        }        
    }
}
