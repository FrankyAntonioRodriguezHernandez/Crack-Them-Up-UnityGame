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

    
}