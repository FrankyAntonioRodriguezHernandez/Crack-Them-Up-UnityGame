using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeastController : MonoBehaviour
{
    private Transform objetivo;
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private float rangoDeAtaque = 1.5f;
    private bool atacando = false;
    private Animator bestiaAnimator;
    private BoxCollider2D boxCollider;

    void Start()
    {
        objetivo = GameObject.Find("Personaje").transform;
        bestiaAnimator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.enabled = false;
    }

    void Update()
    {
        if (objetivo != null)
        {
            // Obtén la dirección hacia el objetivo
            Vector2 direccion = (objetivo.position - transform.position).normalized;

            // Calcula la distancia al objetivo
            float distanciaAlObjetivo = Vector2.Distance(transform.position, objetivo.position);

            // Si está dentro del rango de ataque, ataca
            if (distanciaAlObjetivo <= rangoDeAtaque)
            {
                Atacar();
            }
            else
            {
                // Mueve la bestia hacia el objetivo
                transform.position = Vector2.MoveTowards(transform.position, objetivo.position, velocidad * Time.deltaTime);

                // Configura la rotación de la bestia
                transform.right = direccion;

                // Restaura el booleano cuando no está atacando
                atacando = false;
                // Configura el booleano en el Animator
                bestiaAnimator.SetBool("Atacando", atacando);

                // Desactiva el colisionador cuando no está atacando
                boxCollider.enabled = false;
            }
        }
    }

    void Atacar()
    {
        if (!atacando)
        {
            atacando = true;
            bestiaAnimator.SetBool("Atacando", atacando);
            boxCollider.enabled = true;
        }
    }

}