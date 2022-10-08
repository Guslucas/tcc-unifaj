using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trocafase : MonoBehaviour
{
     public string cenafase1;
     public string cenafase2;
     public string cenafase3;
   public void fase1()
    {
        SceneManager.LoadScene(cenafase1);
    }
    public void fase2()
    {
        SceneManager.LoadScene(cenafase2);
    }
    public void fase3()
    {
        SceneManager.LoadScene(cenafase3);
    }
}
