using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigosRecibirDaño : MonoBehaviour
{

    public int vida;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("colisiono");
        if (collision.tag == "PersonajeProyectil")
        {
            vida = vida - collision.GetComponent<HerirEnemigo>().herir();
            Destroy(collision.gameObject);
        }
    }
}
