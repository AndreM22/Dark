using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDePersonajes : MonoBehaviour
{
    private string personajeActual;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        personajeActual = "Chica";

        animator = GetComponent<Animator>();
        animator.SetBool("SChica", true);

    }

    private void borrarSeleccion()
    {
        animator.SetBool("SEspitiru", false);
        animator.SetBool("SEsqueleto", false);
        animator.SetBool("SChica", false);
    }

    private void SeleccionarChica()
    {
        borrarSeleccion();
        animator.SetBool("SChica", true);
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

    }

    private void SeleccionarEspitiru()
    {
        borrarSeleccion();
        animator.SetBool("SEspitiru", true);
        transform.localScale = new Vector3(0.5f, 0.5f, 1.0f);

    }

    private void SeleccionarEsqueleto()
    {
        borrarSeleccion();
        animator.SetBool("SEsqueleto", true);
        transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);


    }

    // Update is called once per frame
    void Update()
    {

        if(personajeActual != PersonajeStorage.nombrePersonaje)
        {
            personajeActual = PersonajeStorage.nombrePersonaje;
            CambiarEstado(personajeActual);
        }

    }

    private void CambiarEstado(string estado)
    {
        if (estado == "Chica")
        {
            SeleccionarChica();
        }
        else if (estado == "Espiritu")
        {
            SeleccionarEspitiru();
        }
        else if (estado == "Esqueleto")
        {
            SeleccionarEsqueleto();
        }
    }
}
