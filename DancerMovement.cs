using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DancerMovement : MonoBehaviour
{
    private Transform objetivo;
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private float rangoDeAtaque = 1.5f;
    private Animator dancerAnimator;
    private float vidaDancer =2;

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
            Hurt();
        }
    }

    private void Hurt()
    {
        if (vidaDancer > 0)
        {
            vidaDancer--;
           

           
            if (vidaDancer == 0)
            {
               
                Die();
            }
        }
    }

    private void Die()
    {
        
        Destroy(gameObject);
        
    }
}