using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{



    public  void Update()
    {

    }

    public void BotonStart(){
        SceneManager.LoadScene(2);
    }

    public void Botonquit(){
        Debug.Log("Quitamos la aplicacion");
        Application.Quit();
    }

    private void Pause(){
        Time.timeScale =0f;
        flag = true;
        menuPausa.SetActive(true);
    }





}
