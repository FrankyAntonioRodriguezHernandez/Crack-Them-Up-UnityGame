using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForzController : MonoBehaviour
{
    private Transform objetivo;
    [SerializeField] private float velocidad = 5f; 
    [SerializeField] private float rangoDeAtaque = 1.5f; 
    private float vidaForz=2;
    private Animator dancerAnimator;

    void Start()
    {
        objetivo = GameObject.Find("Personaje").transform;
        dancerAnimator = GetComponent<Animator>();
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
                transform.Translate(direccion * velocidad * Time.deltaTime);

                if (direccion.x > 0)
                {
                    transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * -1, transform.localScale.y, transform.localScale.z);
                }
                
                else if (direccion.x < 0)
                {
                    transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x) * -1, transform.localScale.y, transform.localScale.z);
                }

                dancerAnimator.SetBool("Atacando", false);
            }
        }
    }

    void Atacar()
    {
        dancerAnimator.SetBool("Atacando", true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ArmaPersonaje"))
        {
            CausarHerida();
        }
    }

    private void CausarHerida()
    {
        if (vidaForz > 0)
        {
            vidaForz--;
           

           
            if (vidaForz == 0)
            {
               
                Morir();
            }
        }
    }

    private void Morir()
    {
        Destroy(gameObject);
    }
}