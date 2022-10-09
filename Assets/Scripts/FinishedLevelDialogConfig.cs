using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishedLevelDialogConfig : MonoBehaviour
{
    public string NextLevelScene;
    public string HomeScene;

    private void Start()
    {
        GameManager.Instace.SetAndHideEndingDialog(gameObject);
    }

    public void OnNextLevelButtonClicked()
    {
        SceneManager.LoadScene(NextLevelScene);
    }

    public void OnRestartButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnHomeButtonClicked()
    {
        SceneManager.LoadScene(HomeScene);
    }
}