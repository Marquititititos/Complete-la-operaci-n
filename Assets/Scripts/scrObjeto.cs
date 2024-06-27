using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrObjeto : MonoBehaviour
{
    public int precio;
    public int posicion;

    public GameObject boton;
    public Text txtOpcion1;
    public Text txtOpcion2;
    public Text txtOpcion3;

    // Start is called before the first frame update

    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        BtnScript scrBoton = boton.GetComponent<BtnScript>();

        if (posicion == 1)
        {
            scrBoton.respuesta = 1;
            txtOpcion1.color = Color.green;
            txtOpcion2.color = Color.black;
            txtOpcion3.color = Color.black;
        }

        if (posicion == 2)
        {
            scrBoton.respuesta = 2;
            txtOpcion1.color = Color.black;
            txtOpcion2.color = Color.green;
            txtOpcion3.color = Color.black;
        }

        if (posicion == 3)
        {
            scrBoton.respuesta = 3;
            txtOpcion1.color = Color.black;
            txtOpcion2.color = Color.black;
            txtOpcion3.color = Color.green;
        }
    }
}
