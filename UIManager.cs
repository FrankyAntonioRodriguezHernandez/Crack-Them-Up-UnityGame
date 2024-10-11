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
    



}