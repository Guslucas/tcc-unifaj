using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class GameManager : IPersistentSingleton<GameManager>
{
    public Transform currentCheckPoint;
    public Action<string> OnLoadedSceneComplete;

    public string cena;
    private string _currentScene;

    public GameObject EndingDialog;

    private void Start()
    {
        FindObjectOfType<AudioManager>().PlayDelayed("theme");
    }

    private void Update()
    {

    }

   

    public void LoadScene(string sceneName)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
        if (asyncOperation == null)
        {
            Debug.LogError("Erro ao carregar a scene " + sceneName);
            return;
        }
        _currentScene = sceneName;
        asyncOperation.completed += OnSceneLoaded;
    }

    private void OnSceneLoaded(AsyncOperation asyncOperation)
    {
        OnLoadedSceneComplete?.Invoke(_currentScene);
    }

    public void SetAndHideEndingDialog(GameObject newEndingDialog)
    {
        //GameObject newEndingDialog
        EndingDialog = newEndingDialog;
        //EndingDialog = GameObject.Find("FinishedLevelDialog");
        Debug.Log("EndingDialog=" + EndingDialog);
        Instace.HideEndingDialog();
    }

    public void ShowEndingDialog()
    {
        if (EndingDialog == null)
            return;
        EndingDialog.SetActive(true);
    }

    public void HideEndingDialog()
    {
        if (EndingDialog == null)
            return;
        EndingDialog.SetActive(false);
    }

}
