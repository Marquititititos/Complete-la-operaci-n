using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrOperacion : MonoBehaviour
{
    public Text pregunta;
    public GameObject[] opcion1;
    public GameObject[] opcion2;
    public GameObject[] opcion3;
    public GameObject[] objetoOperacion;

    public Text textoOpcion1;
    public Text textoOpcion2;
    public Text textoOpcion3;
    public Text textoObjetoOperacion;
    public Text operacion;

    int objeto1;
    int objeto2;
    int objeto3;
    int valorObjetoOperacion;

    int precioCorrecto;
    public int posicionAzar;

    scrObjeto scrobjeto1;
    scrObjeto scrobjeto2;
    scrObjeto scrobjeto3;
    scrObjeto scrobjetooperacion;

    void Start()
    {
 
        foreach (GameObject obj in opcion1)
        {
            obj.SetActive(false);
        }

        foreach (GameObject obj in opcion2)
        {
            obj.SetActive(false);
        }

        foreach (GameObject obj in opcion3)
        {
            obj.SetActive(false);
        }

        foreach (GameObject obj in objetoOperacion)
        {
            obj.SetActive(false);
        }


        objeto1 = Random.Range(0, opcion1.Length);


        do
        {
            objeto2 = Random.Range(0, opcion2.Length);
        } while (objeto2 == objeto1);


        do
        {
            objeto3 = Random.Range(0, opcion3.Length);
        } while (objeto3 == objeto1 || objeto3 == objeto2);

        valorObjetoOperacion = Random.Range(0, objetoOperacion.Length);

        opcion1[objeto1].SetActive(true);
        opcion2[objeto2].SetActive(true);
        opcion3[objeto3].SetActive(true);
        objetoOperacion[valorObjetoOperacion].SetActive(true);

        scrobjeto1 = opcion1[objeto1].GetComponent<scrObjeto>();
        scrobjeto2 = opcion2[objeto2].GetComponent<scrObjeto>();
        scrobjeto3 = opcion3[objeto3].GetComponent<scrObjeto>();
        scrobjetooperacion = objetoOperacion[valorObjetoOperacion].GetComponent<scrObjeto>();

        textoOpcion1.text = scrobjeto1.precio.ToString();
        textoOpcion2.text = scrobjeto2.precio.ToString();
        textoOpcion3.text = scrobjeto3.precio.ToString();
        textoObjetoOperacion.text = scrobjetooperacion.precio.ToString();


        posicionAzar = Random.Range(1, 4);

        if (posicionAzar == 1)
        {
            precioCorrecto = scrobjeto1.precio;
        }
        else if (posicionAzar == 2)
        {
            precioCorrecto = scrobjeto2.precio;
        }
        else if (posicionAzar == 3)
        {
            precioCorrecto = scrobjeto3.precio;
        }

        operacion.text = " + ____ = " + (precioCorrecto + scrobjetooperacion.precio);
    }
}

