using System.Collections;
using UnityEngine;

public class BossController : MonoBehaviour
{
    private Transform objetivo;
    private float rangoDeAtaque = 1.5f; 

    private Animator botAnimator;

    void Start()
    {
        botAnimator = GetComponent<Animator>();
        objetivo = GameObject.Find("Personaje").transform;
    }

    void Update()
    {
        if (objetivo != null)
        {
            Vector2 direccion = (objetivo.position - transform.position).normalized;

            float distanciaAlObjetivo = Vector2.Distance(transform.position, objetivo.position);

            if (distanciaAlObjetivo <= rangoDeAtaque)
            {
                Atacar();
            }
        }
    }

    void Atacar()
    {
        botAnimator.SetBool("Atacando", true);
    }
}