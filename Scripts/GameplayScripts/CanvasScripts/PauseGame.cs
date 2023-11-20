using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour // Este script se encarga de pausar el juego
{
    [SerializeField] FinalGame finalGame; // Referencia al script FinalGame para no poder mostrar el panel de pausa cuando el juego haya terminado.
    [SerializeField] GameObject panelPause;
    public bool isPaused;
    void Start()
    {
        panelPause.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !finalGame.isFinalGame)
        {
            ShowPausePanel();
            UpdateGameState();
        }
    }

    public void UpdateGameState()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    private void ShowPausePanel()
    {
        if (!isPaused)
        {
            panelPause.SetActive(true);
        }
        else
        {
            panelPause.SetActive(false);
        }
    }
    /*---------------- Funciones para los botones del panel ----------------*/
    public void Continuar()
    {
        UpdateGameState();
        panelPause.SetActive(false);
    }
    public void Inventory(int n)
    {
        UpdateGameState();
        SceneManager.LoadScene(n);
    }
    public void MainMenu(int n)
    {
        UpdateGameState();
        SceneManager.LoadScene(n);
    }
}
