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






}