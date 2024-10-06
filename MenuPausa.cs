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

}
