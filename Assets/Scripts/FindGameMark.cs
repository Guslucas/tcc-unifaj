using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameMark : MonoBehaviour
{
    private void OnMouseDown()
    {
        //Debug.Log("Erro selecionado");
        FindObjectOfType<AudioManager>().Play("SelectedError");


        Destroy(this.gameObject);

        
    }
}
