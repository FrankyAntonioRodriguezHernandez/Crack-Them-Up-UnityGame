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