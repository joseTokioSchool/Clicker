using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalGame : MonoBehaviour // Este script se encarga de mostrar el panel de Final del Juego y del comportamiento de sus botones.
{
    [SerializeField] GameObject panel;
    [SerializeField] Chronometer chronometer; // Referencia al script Chronometer para mostrar el panel de Final del Juego cuando el tiempo llegue a 0.
    public bool isFinalGame;
    void Start()
    {
        panel.SetActive(false);
    }

    void Update()
    {
        if (chronometer.timer <= 0)
        {
            isFinalGame = true;
            panel.SetActive(true);
        }
    }
    /*---------------- Funciones para los botones del panel ----------------*/
    public void Inventory(int n)
    {
        SceneManager.LoadScene(n);
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainMenu(int n)
    {
        SceneManager.LoadScene(n);
    }

}
