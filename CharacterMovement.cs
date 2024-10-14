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
    if (jugadorHaMuerto)
        {
            menuDerrota.SetActive(true);
        }

    float movH = Input.GetAxisRaw("Horizontal");
    float movY = Input.GetAxisRaw("Vertical");

    direccion = new Vector2(movH, movY).normalized;

    if (movH != 0)
    {
        float spriteScaleX = 0.5f;
        float spriteScaleY = 0.5f;
        float spriteScaleZ = 0.5f;
        transform.localScale = new Vector3(Mathf.Sign(movH) * spriteScaleX, spriteScaleY, spriteScaleZ);
    }

    playerAnimator.SetFloat("Horizontal", movH);
    playerAnimator.SetFloat("Vertical", movY);
    playerAnimator.SetFloat("velocidad", direccion.sqrMagnitude);
    particulas.Play();

    if (Input.GetMouseButtonDown(0))
        {
            Atacar();
        }

}

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direccion * velocidad * Time.fixedDeltaTime);
    }

    private void Atacar()
    {
        atacando = true;
        playerAnimator.SetBool("Atacar", atacando);
        Invoke("DetenerAtaque", playerAnimator.GetCurrentAnimatorStateInfo(0).length);
    }

    private void DetenerAtaque()
    {
        // Desactiva el parámetro "Atacar" en el Animator
        atacando = false;
        playerAnimator.SetBool("Atacar", atacando);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bestia") || other.CompareTag("DancerAttack")|| other.CompareTag("AtaqueForz"))
        {
            CausarHerida();
        }
    }

    private void CausarHerida()
    {
        if (vidaPersonaje > 0)
        {
            vidaPersonaje--;
            uiManager.RestaVidas(vidaPersonaje);

            if (vidaPersonaje <= 0)
            {
                jugadorHaMuerto = true;
                Morir();
            }
        }
    }

    private void CurarHerida()
{
    if (vidaPersonaje > 0 && vidaPersonaje < 5)
    {
        if (uiManager.cantidadRisas >= 30)
        {
            uiManager.RestarRisas(30);
            uiManager.SumarVidas(vidaPersonaje);
            vidaPersonaje++;
        }
        else
        {
            Debug.Log("No tienes suficientes risas para curarte.");
        }
    }
}

    private void Morir()
    {
        Destroy(gameObject);
        Time.timeScale =0f;
        menuDerrota.SetActive(true);
        
    }
}