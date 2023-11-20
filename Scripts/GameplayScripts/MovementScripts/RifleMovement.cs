using UnityEngine;

public class RifleMovement : MonoBehaviour // Este script se encarga de mover el rifle.
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private float offset = 1.5f;
    [SerializeField] PauseGame pauseGame; // Referencia al script PauseGame para poder detener el movimiento del objeto cuando el juego esté en pausa.
    [SerializeField] FinalGame finalGame; // Referencia al script FinalGame para poder detener el movimiento del objeto cuando el juego haya terminado.
    private Camera cameraRifle;

    void Start()
    {
        cameraRifle = Camera.main;
    }

    void LateUpdate()
    {
        if (!pauseGame.isPaused && !finalGame.isFinalGame)
        {
            SpriteMovement();
        }
    }
    private void SpriteMovement()
    {
        Vector2 mousePos = cameraRifle.ScreenToWorldPoint(Input.mousePosition);
        bool flip = mousePos.x < 0;
        spriteRenderer.flipX = flip;
        transform.position = new Vector3(Mathf.Clamp(mousePos.x + (flip ? -offset : offset), -8.5f, 8.5f), transform.position.y);
    }
}
