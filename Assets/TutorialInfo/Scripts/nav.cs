using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class nav : MonoBehaviour
{
    public string navigation; // Nom de la scène à charger

    private void OnMouseDown()
    {
        SceneManager.LoadScene("navigation"); // Charger la scène spécifiée par le nom
    }
}


