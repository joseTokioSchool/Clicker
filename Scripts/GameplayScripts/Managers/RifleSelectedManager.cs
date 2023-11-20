using UnityEngine;

public class RifleSelectedManager : MonoBehaviour //Este script se encarga de mostrar el arma seleccionada en la escena Inventario.
{
    [SerializeField] GameObject woodRifle;
    [SerializeField] GameObject silverRifle;
    [SerializeField] GameObject goldRifle;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Rifle") == 1)
        {
            woodRifle.SetActive(true);
            silverRifle.SetActive(false);
            goldRifle.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Rifle") == 2)
        {
            woodRifle.SetActive(false);
            silverRifle.SetActive(true);
            goldRifle.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Rifle") == 3)
        {
            woodRifle.SetActive(false);
            silverRifle.SetActive(false);
            goldRifle.SetActive(true);
        }
    }
}
