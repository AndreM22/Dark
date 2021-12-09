using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeSelector : MonoBehaviour
{
    public GameObject Chica;
    public GameObject Espiritu;
    public GameObject Esqueleto;
    private string[] personajes;
    private int indice;


    // Start is called before the first frame update
    void Start()
    {
        indice = 0;
        personajes = new string[] { "Chica", "Espiritu", "Esqueleto" };
        PersonajeStorage.nombrePersonaje = "Chica";
        PersonajeStorage.personajePrefab = Chica;
        PersonajeStorage.estadisticas = new int[] { 3, 3, 3, 1, 4 };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            indice = (indice + 1) % personajes.Length;
            actualizarSeleccion();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            indice = (indice + personajes.Length - 1) % personajes.Length;
            actualizarSeleccion();

        }
    }

    private void actualizarSeleccion()
    {
        if (personajes[indice] == "Chica")
        {
            PersonajeStorage.nombrePersonaje = "Chica";
            PersonajeStorage.personajePrefab = Chica;
            PersonajeStorage.estadisticas = new int[] { 3,3,3,1,4};
        }
        else if (personajes[indice] == "Espiritu")
        {
            PersonajeStorage.nombrePersonaje = "Espiritu";
            PersonajeStorage.personajePrefab = Espiritu;
            PersonajeStorage.estadisticas = new int[] { 5, 1, 4, 3, 3 };
            
        }
        else if (personajes[indice] == "Esqueleto")
        {
            PersonajeStorage.nombrePersonaje = "Esqueleto";
            PersonajeStorage.personajePrefab = Esqueleto;
            PersonajeStorage.estadisticas = new int[] { 2, 5, 3, 4, 2 };
        }
    }
}
