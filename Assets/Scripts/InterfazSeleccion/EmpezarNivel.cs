using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmpezarNivel : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        print("Cambiando escena");
        SceneManager.LoadScene(sceneName);
    }
}
