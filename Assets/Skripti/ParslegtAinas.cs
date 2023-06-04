using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParslegtAinas : MonoBehaviour {
    public float laiks;
    public void UzSakumu()
    {
        SceneManager.LoadScene("Starta", LoadSceneMode.Single);
    }
    //Pašiem jāuztaisa metode,kas pārslēdzno sākuma uz UI ainu
    public void uzUI()
    {
        SceneManager.LoadScene("PilsetasAina", LoadSceneMode.Single);
    }
    public void Apturet()
    {
        Application.Quit();
    }
}
