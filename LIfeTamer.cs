using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaTamer : MonoBehaviour
{
    private float vidaTamer=2;
    private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("ArmaPersonaje"))
            {
                CausarHerida();
            }
        }

    private void CausarHerida()
        {
            if (vidaTamer > 0)
            {
                vidaTamer--;
           
            
        }
    }
}
