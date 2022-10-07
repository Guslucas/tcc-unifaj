using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameMark : MonoBehaviour
{
    AudioManager AudioManager;

    private void OnMouseDown()
    {
        Debug.Log("Erro selecionado");

        Destroy(this.gameObject);

        
    }
}
