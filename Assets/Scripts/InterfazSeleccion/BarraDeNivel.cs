using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraDeNivel : MonoBehaviour
{
    public int indice;

    public string personajeActual;

    public Sprite nivel1;
    public Sprite nivel2;
    public Sprite nivel3;
    public Sprite nivel4;
    public Sprite nivel5;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        personajeActual = "Ningun personaje seleccionado";
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if( personajeActual != PersonajeStorage.nombrePersonaje)
        {
            personajeActual = PersonajeStorage.nombrePersonaje;
            ponerImagen(PersonajeStorage.estadisticas[indice]);
        }
    }

    private void ponerImagen (int i)
    {
        if(i == 1)
        {
            spriteRenderer.sprite = nivel1;
        }
        else if (i == 2)
        {
            spriteRenderer.sprite = nivel2;
        }
        else if (i == 3)
        {
            spriteRenderer.sprite = nivel3;
        }
        else if (i == 4)
        {
            spriteRenderer.sprite = nivel4;
        }
        else if (i == 5)
        {
            spriteRenderer.sprite = nivel5;
        }
    }
}
