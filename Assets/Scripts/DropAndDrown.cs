using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DropAndDrown : MonoBehaviour
{
    public GameObject SelectPiece;
    int OIL = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit && hit.transform.CompareTag("Puzzle"))
            {
               if (!hit.transform.GetComponent<piceseScript>().InRightPosition)
                {
                    SelectPiece = hit.transform.gameObject;
                    SelectPiece.GetComponent<piceseScript>().Selected = true;
                    SelectPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                    OIL++;
                }
               
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (SelectPiece != null)
            {
                SelectPiece.GetComponent<piceseScript>().Selected = false;
                SelectPiece = null;
            }
        }

        if(SelectPiece != null){
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }
}
