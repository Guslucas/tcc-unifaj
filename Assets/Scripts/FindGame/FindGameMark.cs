using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameMark : MonoBehaviour
{
    AudioManager audioManager;
    FindGameManager gameManager;

    public GameObject x;
    
    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        gameManager = FindObjectOfType<FindGameManager>();
    }

    private void OnMouseDown()
    {
        //Debug.Log("Erro selecionado");

        audioManager.Play("SelectedError");

        gameManager.GetPoints(1);

        Destroy(this.gameObject);

        Instantiate(x, transform.position, x.transform.rotation);
    }
}
