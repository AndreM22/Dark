using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchScript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private int indice;
    private int persistencia;

    public float recarga;
    private float ultimaAparicion;
    public Sprite[] apariciones;

    // Start is called before the first frame update
    void Start()
    {
        indice = 0;
        persistencia = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        if(spriteRenderer.enabled == true)
        {
            persistencia = persistencia + 1;
            if(persistencia == 5)
            {
                spriteRenderer.enabled = false;
                persistencia = 0;
            }
        }

        if(Time.time > ultimaAparicion + recarga)
        {
            ultimaAparicion = Time.time;
            spriteRenderer.sprite = apariciones[indice % (apariciones.Length)];
            spriteRenderer.enabled = true;
            indice = indice + 1;
        }
    }
}
