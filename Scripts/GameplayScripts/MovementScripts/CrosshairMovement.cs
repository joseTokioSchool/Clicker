using UnityEngine;

public class CrosshairMovement : MonoBehaviour // Este script se encarga de mover el Crosshair.
{
    [SerializeField] PauseGame pauseGame; // Referencia al script PauseGame para poder detener el movimiento del objeto cuando el juego esté en pausa.
    [SerializeField] FinalGame finalGame; // Referencia al script FinalGame para poder detener el movimiento del objeto cuando el juego haya terminado.
    private Camera cameraCrosshair;
    void Start()
    {
        cameraCrosshair = Camera.main;
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
        Vector2 mousePos = cameraCrosshair.ScreenToWorldPoint(Input.mousePosition);
        Cursor.visible = mousePos.x < -8.5f || mousePos.x > 8.5f || mousePos.y < -3.5f || mousePos.y > 4.5f;
        transform.position = new Vector3(Mathf.Clamp(mousePos.x, -8.5f, 8.5f), Mathf.Clamp(mousePos.y, -3.5f, 4.5f));
    }
}
