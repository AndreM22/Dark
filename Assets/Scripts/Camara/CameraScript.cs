using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject personaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        personaje = ControladorPersonajeScript.personaje;
        if (personaje == null)
        {
            personaje = ControladorPersonajeScript.personaje;
            return;
        }
        Vector3 position = transform.position;
        if (personaje.transform.position.x > 0f && personaje.transform.position.x < 16f)
        {
            position.x = personaje.transform.position.x;
            transform.position = position;
        }
    }
}
