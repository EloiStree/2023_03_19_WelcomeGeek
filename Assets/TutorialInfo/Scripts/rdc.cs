using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class rdc : MonoBehaviour
{
    public string rezdechauss; // Nom de la scène à charger

    private void OnMouseDown()
    {
        SceneManager.LoadScene("rezdechauss"); // Charger la scène spécifiée par le nom
    }
}
