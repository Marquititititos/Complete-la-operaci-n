using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnScript : MonoBehaviour
{
    public GameObject objetoConScrOperacion;
    public GameObject panelCorrecto;
    public GameObject panelIncorrecto;
    public GameObject panelNoRespuesta;
    public int respuesta;

    public Text txtOpcion1;
    public Text txtOpcion2; 
    public Text txtOpcion3;


    private scrOperacion operacionScript;

    void Start()
    {

        operacionScript = objetoConScrOperacion.GetComponent<scrOperacion>();

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

    // Paneles

    public void BtnCerrar()
    {
        panelNoRespuesta.SetActive(false);
        panelIncorrecto.SetActive(false);
    }

    public void BtnReintentar()
    {
        SceneManager.LoadScene("momo");
    }

    public void BtnSalir()
    {
        SceneManager.LoadScene("SeleccionarJuegos");
    }
}

