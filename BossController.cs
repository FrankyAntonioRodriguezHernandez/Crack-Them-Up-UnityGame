using System.Collections;
using UnityEngine;

public class BossController : MonoBehaviour
{
    private Transform objetivo; // El objetivo a atacar (puedes configurarlo en el Inspector)
    private float rangoDeAtaque = 1.5f; // Rango de ataque del bot

    private Animator botAnimator;

    void Start()
    {
        botAnimator = GetComponent<Animator>();
        // Encuentra el objetivo por su nombre (asegúrate de que el objetivo tenga el nombre correcto)
        objetivo = GameObject.Find("Personaje").transform;
    }

    void Atacar()
    {
        // Configura el booleano "Atacando" en el Animator
        botAnimator.SetBool("Atacando", true);
        // Implementa aquí la lógica de ataque del bot
        // ...

        // Puedes agregar una lógica para detener la animación de ataque después de un tiempo
        // usando Invoke o algún otro método según tus necesidades
    }




}