using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class dems : MonoBehaviour
{
    public string deuxieme; // Nom de la scène à charger

    private void OnMouseDown()
    {
        SceneManager.LoadScene("deuxieme"); // Charger la scène spécifiée par le nom
    }
}


