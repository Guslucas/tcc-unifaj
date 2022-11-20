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
    public void QuitGame()
    {

        //Editor Unity enquanto for editando deixa esse campo descomentado
        //UnityEditor.EditorApplication.isPlaying = false;
        //jogo compilado, antes de compliar comenta linha a cima descomenta linha abaixo
        Application.Quit();

    }
}
