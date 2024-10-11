using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class TransicionEscena : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private AnimationClip animacionFinal;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    IEnumerator CambiarEscena()
    {
        animator.SetTrigger("Iniciar");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(2);
    }

    public void BotonStart(){
        StartCoroutine(CambiarEscena());
    }

    public void Botonquit(){
        Debug.Log("Quitamos la aplicacion");
        Application.Quit();
    }

}
