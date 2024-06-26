using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnScript : MonoBehaviour
{
    public GameObject objetoConScrOperacion;
    public Text correcto;
    public GameObject panelCorrecto;
    int respuesta;


    private scrOperacion operacionScript;

    void Start()
    {

        operacionScript = objetoConScrOperacion.GetComponent<scrOperacion>();
        panelCorrecto.SetActive(true);

    }

    void Btn1()
    {
        respuesta = 1;

    }
    void Btn2()
    {
        respuesta = 2;

    }
    void Btn3()
    {
        respuesta = 3;

    }
}

