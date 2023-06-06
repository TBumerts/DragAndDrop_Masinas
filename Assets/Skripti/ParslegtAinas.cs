using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParslegtAinas : MonoBehaviour {
    public void UzSakumu()
    {
        SceneManager.LoadScene("Starta", LoadSceneMode.Single);
    }
    public void uzUI()
    {
        SceneManager.LoadScene("PilsetasAina", LoadSceneMode.Single);
    }
    public void Apturet()
    {
        Application.Quit();
    }
}
