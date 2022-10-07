using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameMark : MonoBehaviour
{
    AudioManager audioManager;
    FindGameManager gameManager;
    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        gameManager = FindObjectOfType<FindGameManager>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Erro selecionado");

        audioManager.Play("SelectedError");

        gameManager.EndGame(1);

        Destroy(this.gameObject);
    }
}
