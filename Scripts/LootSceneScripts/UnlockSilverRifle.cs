using UnityEngine;

public class UnlockSilverRifle : MonoBehaviour // Este Script se encarga de desactivar el panel de "Bloqueado", activar el botón para poder seleccionar el arma, restar el coste del arma a los puntos y desactivar el collider para no poder seguir restando mas puntos en caso de ya haber desbloqueado el arma.
{
    [SerializeField] GameObject silverRiflePanel;
    [SerializeField] GameObject buttonSilver;
    [SerializeField] GameObject selectedText;
    private void Start()
    {
        if (PlayerPrefs.GetInt("SilverRifleUnlocked") == 1)
        {
            silverRiflePanel.SetActive(false);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            buttonSilver.SetActive(true);
            selectedText.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("Score") >= 35 && PlayerPrefs.GetInt("SilverRifleUnlocked") == 0)
        {
            PlayerPrefs.SetInt("SilverRifleUnlocked", 1);
            silverRiflePanel.SetActive(false);
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - 35);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            buttonSilver.SetActive(true);
            selectedText.SetActive(false);
            Debug.Log("Presionado");
        }
    }
}
