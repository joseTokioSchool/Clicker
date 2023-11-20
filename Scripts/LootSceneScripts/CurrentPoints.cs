using TMPro;
using UnityEngine;

public class CurrentPoints : MonoBehaviour // Este script sirve para mostrar los puntos acumulados en la escena de Inventario
{
    [SerializeField] private TMP_Text scoreTest;
    void Update()
    {
        scoreTest.text = "Points: " + PlayerPrefs.GetInt("Score").ToString();
    }
}
