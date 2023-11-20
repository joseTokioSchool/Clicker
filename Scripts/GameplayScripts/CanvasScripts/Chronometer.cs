using TMPro;
using UnityEngine;

public class Chronometer : MonoBehaviour
{
    [SerializeField] PauseGame pauseGame; // Referencia al script PauseGame para detener el juego cuando esté en pausa.
    [SerializeField] FinalGame finalGame; // Referencia al script FinalGame para detener el juego cuando haya terminado y al reiniciar el juego este siga funcionando.
    [SerializeField] TMP_Text chronoText;
    public float timer;

    void Start()
    {
        timer = 30;
    }
    void Update()
    {
        if (timer <= 30 && timer > 0 && !pauseGame.isPaused && !finalGame.isFinalGame)
        {
            Time.timeScale = 1f;
            timer -= Time.deltaTime;
            chronoText.text = "Time: " + timer.ToString("F0");
        }
        else if (timer <= 0)
        {
            timer = 0;
            chronoText.text = "Time: " + timer.ToString();
            Time.timeScale = 0f;
        }
    }
}
