using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PuzzlePiece : MonoBehaviour
{
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;

    private static int i = 0;

    private const bool CreateShadows = true;
    private static GameObject ShadowsParent;

    void Start()
    {
        RightPosition = transform.position;

        if (CreateShadows)
        {
            if (ShadowsParent == null)
                ShadowsParent = GameObject.Find("Shadows");
            Debug.Log("Creating shadow for " + name);
            GameObject shadow = new GameObject(name + "_shadow");
            shadow.transform.SetParent(ShadowsParent.transform);
            shadow.transform.position = transform.position;
            SpriteRenderer shadowSpriteRenderer = shadow.AddComponent<SpriteRenderer>();
            shadowSpriteRenderer.color = new Color(0, 0, 0, .46f);
            shadowSpriteRenderer.sprite = GetComponent<SpriteRenderer>().sprite;
            shadowSpriteRenderer.sortingOrder = GetComponent<SpriteRenderer>().sortingOrder - 1;
        }

        //transform.position = new Vector3(Random.Range(-9.28f, 9.25f), Random.Range(0.23f, -4.46f));

        transform.position = new Vector3(-8.03f + (1.92f * i), -0.86f);

        i++;
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
                    Camera.main.GetComponent<DragAndDrop_>().PieceFit();
                }
            }
        }
    }
}
