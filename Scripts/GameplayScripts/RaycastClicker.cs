using UnityEngine;

public class RaycastClicker : MonoBehaviour // Este script se encarga, mediante un Raycast, de detectar si hemos pulsado en un Target, reproducir el sonido de disparo y aumentar la puntuación.
{
    [SerializeField] Camera cam;
    [SerializeField] AudioSource rifleSource;
    [SerializeField] AudioClip shootClip;
    [SerializeField] PauseGame pauseGame; // Referencia al script PauseGame para dejar de puntuar cuando el juego esté en pausa.
    [SerializeField] FinalGame finalGame; // Referencia al script FinalGame para dejar de puntuar cuando el juego haya terminado.
    void Start()
    {
        cam = Camera.main;
        rifleSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0) && !pauseGame.isPaused && !finalGame.isFinalGame)
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 10f))
            {
                if (hit.collider.gameObject.layer == 3)
                {
                    rifleSource.PlayOneShot(shootClip);
                    hit.collider.gameObject.SetActive(false);
                    GameManager.Instance.PlayerScored();
                    Debug.Log("Hit" + "| Puntos actuales: " + GameManager.Instance.playerScored + " | Record: " + PlayerPrefs.GetInt("Score"));
                }
            }

        }
    }
}
