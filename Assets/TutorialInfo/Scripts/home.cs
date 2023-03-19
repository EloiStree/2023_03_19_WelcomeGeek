using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
    public string accueilSc; // Nom de la scène à charger

    private void OnMouseDown()
    {
        SceneManager.LoadScene("accueilSc"); // Charger la scène spécifiée par le nom
    }
}

