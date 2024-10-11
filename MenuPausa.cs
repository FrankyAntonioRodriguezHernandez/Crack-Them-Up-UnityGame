using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject menuPausa;

    private bool flag=false;

    public  void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!flag)
            {
                Pause();
            }
            else{
                Reanudar();
            }
        }
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

    private void Continue(){
        Time.timeScale =1f;
        flag = false;
        menuPausa.SetActive(false);
    }



}
