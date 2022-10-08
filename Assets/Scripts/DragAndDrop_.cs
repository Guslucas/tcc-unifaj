using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class DragAndDrop_ : MonoBehaviour
{
    //public Sprite[] Levels;

    //public GameObject EndMenu;
    public GameObject SelectedPiece;
    int OIL = 1;    
    public int PlacedPieces = 0;
    private Vector3 diff;

    public int pieceQuantity;

    void Start()
    {
        //for (int i = 0;i < 36; i++)
        //{
        //    GameObject.Find("Piece (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Levels[PlayerPrefs.GetInt("Level")];
        //}
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit && hit.transform.CompareTag("PuzzlePiece"))
            {
                if (!hit.transform.GetComponent<PuzzlePiece>().InRightPosition)
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PuzzlePiece>().Selected = true;
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                    OIL++;

                    diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - hit.transform.position;
                    diff = new Vector3(diff.x, diff.y, 0);
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<PuzzlePiece>().Selected = false;
                SelectedPiece = null;
                diff = Vector3.zero;
            }
        }
        if (SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x,MousePoint.y,0) - diff;
        }             
        
        if (PlacedPieces == pieceQuantity)
        {
            FindObjectOfType<AudioManager>().PlayDelayed("victory");
            Destroy(this);
            //EndMenu.SetActive(true);
        }
    }

    internal void PieceFit()
    {
        PlacedPieces++;
        FindObjectOfType<AudioManager>().Play("click6");
    }

    /*public void NextLevel()
{
   PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level")+1);
   SceneManager.LoadScene("Game");
}

public void BacktoMenu()
{
   SceneManager.LoadScene("Menu");
}*/
}