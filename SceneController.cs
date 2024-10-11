using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscena : MonoBehaviour
{
    public float duracionEscena = 5f; // Duración en segundos
    public string nombreSiguienteEscena; // Nombre de la siguiente escena

    void Start()
    {
        // Inicia el temporizador para cambiar a la siguiente escena después de la duración especificada
        Invoke("CambiarEscena", duracionEscena);
    }

    void CambiarEscena()
    {
        // Cambia a la siguiente escena
        SceneManager.LoadScene(nombreSiguienteEscena);
    }
}