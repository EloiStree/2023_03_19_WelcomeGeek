using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class prems : MonoBehaviour
{
    public string premier; // Nom de la scène à charger

    private void OnMouseDown()
    {
        SceneManager.LoadScene("premier"); // Charger la scène spécifiée par le nom
    }
}

