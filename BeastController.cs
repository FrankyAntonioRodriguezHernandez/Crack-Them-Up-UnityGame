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