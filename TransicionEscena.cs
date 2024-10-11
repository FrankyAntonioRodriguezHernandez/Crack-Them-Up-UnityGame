using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class TransicionEscena : MonoBehaviour
{


    public void BotonStart(){
        StartCoroutine(CambiarEscena());
    }

    public void Botonquit(){
        Debug.Log("Quitamos la aplicacion");
        Application.Quit();
    }

}
