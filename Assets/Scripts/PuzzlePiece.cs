using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PuzzlePiece : MonoBehaviour
{
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(-9.28f, 9.25f), Random.Range(0.23f, -4.46f));
    }
    
    void Update()
    {
        if (Selected)
            Debug.Log("Distance from right position: " + Vector3.Distance(transform.position, RightPosition));
        if (Vector3.Distance(transform.position, RightPosition) < .5f)
        {
            if (!Selected)
            {
                if (InRightPosition == false)
                {
                    transform.position = RightPosition;
                    InRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    Camera.main.GetComponent<DragAndDrop_>().PlacedPieces++;
                }
            }
        }
    }
}
