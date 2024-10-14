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

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direccion * velocidad * Time.fixedDeltaTime);
    }

    if (Input.GetMouseButtonDown(0))
        {
            Atacar();
        }

    private void Atacar()
    {
        atacando = true;
        playerAnimator.SetBool("Atacar", atacando);
        Invoke("DetenerAtaque", playerAnimator.GetCurrentAnimatorStateInfo(0).length);
    }

}





}