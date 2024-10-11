using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UiManager : MonoBehaviour{

    [SerializeField] private List <GameObject> listaVidas;
    [SerializeField] private Sprite mascaraRota;
    [SerializeField] private Sprite mascara;
    public int cantidadRisas;
    [SerializeField] private TMP_Text textoRisas;

    private void Start()
    {
        // Inicia la invocación repetida para aumentar las risas cada 15 segundos
        InvokeRepeating("AumentarRisasPeriodicamente", 0f, 15f);
    }

    private void AumentarRisasPeriodicamente()
    {
        // Aumenta la cantidad de risas en 20
        AumentarRisas(20);

        // Actualiza el texto que muestra la cantidad de risas
        ActualizarTextoRisas();
    }

    public void AumentarRisas(int cantidad)
    {
        cantidadRisas += cantidad;
    }

    private void ActualizarTextoRisas()
    {
        // Actualiza el texto que muestra la cantidad de risas
        textoRisas.text =   cantidadRisas.ToString();
    }
     public void RestarRisas(int cantidad)
    {
        // Restar la cantidad de risas
        cantidadRisas -= cantidad;

        // Actualizar el texto en tu UI
        textoRisas.text = cantidadRisas.ToString();
    }

    public void RestaVidas(int indice)
    {
        Image imagenMascara = listaVidas[indice].GetComponent<Image>();
        imagenMascara.sprite = mascaraRota;
    }
    
}