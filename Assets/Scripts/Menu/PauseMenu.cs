using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Home(string cena)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(cena);

    }
    public void RestartButton(string cena)
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
