using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzleSelectFase : MonoBehaviour
{
    public GameObject StartPanel;
    public void SetPuzzlesPhoto(Image Photo)
    {
        for (int i = 0; i < 16; i++)
        {
            GameObject.Find("pieces" + i).transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite=Photo.sprite;
        }
        
        StartPanel.SetActive(false);
    }
}
