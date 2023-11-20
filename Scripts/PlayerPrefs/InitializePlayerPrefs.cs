using UnityEngine;

public class InitializePlayerPrefs : MonoBehaviour //Este script sirve para inicializar los PlayerPrefs.
{
    private void Awake()
    {
        if (PlayerPrefs.HasKey("Score") == false) // Máximo número de puntos conseguidos en una partida.
        {
            PlayerPrefs.SetInt("Score", 0);
        }
        if (PlayerPrefs.HasKey("Rifle") == false) // Para guardar el arma seleccionada en la escena Inventario y mostrarla en la partida.
        {
            PlayerPrefs.SetInt("Rifle", 1);
        }
        if (PlayerPrefs.HasKey("SilverRifleUnlocked") == false) // Para guardar que hemos comprado el arma o no. 0 == false | 1 == true.
        {
            PlayerPrefs.SetInt("SilverRifleUnlocked", 0);
        }
        if (PlayerPrefs.HasKey("GoldRifleUnlocked") == false) // Para guardar que hemos comprado el arma o no. 0 == false | 1 == true.
        {
            PlayerPrefs.SetInt("GoldRifleUnlocked", 0);
        }
    }
}
