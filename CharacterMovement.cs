using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField] private ParticleSystem particulas;
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private UiManager uiManager;
    private Rigidbody2D rb;
    [SerializeField] private int vidaPersonaje = 5;
    private Animator playerAnimator;
    private Vector2 direccion;
    [SerializeField] private GameObject menuDerrota;
    private bool jugadorHaMuerto =false ;


private void void Start()
{
    rb = GetComponent<Rigidbody2D>();
    playerAnimator = GetComponent<Animator>();
}

private void void Update()
{
    
}





}