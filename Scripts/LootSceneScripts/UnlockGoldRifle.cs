using UnityEngine;

public class UnlockGoldRifle : MonoBehaviour // Este Script se encarga de desactivar el panel de "Bloqueado", activar el botón para poder seleccionar el arma, restar el coste del arma a los puntos y desactivar el collider para no poder seguir restando mas puntos en caso de ya haber desbloqueado el arma.
{
    [SerializeField] GameObject goldRiflePanel;
    [SerializeField] GameObject buttonGold;
    [SerializeField] GameObject selectedText;

    private void Start()
    {
        if (PlayerPrefs.GetInt("GoldRifleUnlocked") == 1)
        {
            goldRiflePanel.SetActive(false);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            buttonGold.SetActive(true);
            selectedText.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("Score") >= 70 && PlayerPrefs.GetInt("GoldRifleUnlocked") == 0)
        {
            PlayerPrefs.SetInt("GoldRifleUnlocked", 1);
            goldRiflePanel.SetActive(false);
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - 70);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            buttonGold.SetActive(true);
            selectedText.SetActive(false);
            Debug.Log("Presionado");
        }
    }
}
