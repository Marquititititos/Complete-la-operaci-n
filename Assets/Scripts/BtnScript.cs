using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnScript : MonoBehaviour
{
    public GameObject objetoConScrOperacion;
    public GameObject panelCorrecto;
    public GameObject panelIncorrecto;
    public GameObject panelNoRespuesta;
    int respuesta;


    private scrOperacion operacionScript;

    void Start()
    {

        operacionScript = objetoConScrOperacion.GetComponent<scrOperacion>();

    }

    public void Btn1()
    {
        respuesta = 1;

    }
    public void Btn2()
    {
        respuesta = 2;

    }
    public void Btn3()
    {
        respuesta = 3;

    }

    public void Responder()
    {
        if (respuesta == operacionScript.posicionAzar)
        {
            panelCorrecto.SetActive(true);
        } 
        else if (respuesta == 0)
        {
            panelNoRespuesta.SetActive(true);
        } else
        {
            panelIncorrecto.SetActive(true);
        }
    }
}

