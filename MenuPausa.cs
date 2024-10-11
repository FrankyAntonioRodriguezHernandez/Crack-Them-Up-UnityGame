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

    public void Botonsalir(){
        SceneManager.LoadScene(1);
        Time.timeScale =1f;
    }

    public void BotonRestart(){
        flag = false;
        SceneManager.LoadScene(3);
        Time.timeScale =1f;
    }

    public void MuteHandler(bool mute){
        if(mute){
           AudioListener.volume=0;
        }
        else{
            AudioListener.volume=1;
        }
    }

    
}
