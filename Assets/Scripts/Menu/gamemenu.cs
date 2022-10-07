using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gamemenu : MonoBehaviour
{
     public string cena;
   public void StartGame()
    {
        SceneManager.LoadScene(cena);
    }
}
