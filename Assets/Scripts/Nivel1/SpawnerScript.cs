using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        print("Crear spawner");
        ControladorPersonajeScript.personaje = Instantiate(PersonajeStorage.personajePrefab, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }

}
