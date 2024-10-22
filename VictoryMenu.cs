using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryMenu : MonoBehaviour
{
    public GameObject menuEmergente;

    void Start()
    {
        menuEmergente.SetActive(false);
    }

    public void MostrarMenuEmergente()
    {
        menuEmergente.SetActive(true);
    }
}