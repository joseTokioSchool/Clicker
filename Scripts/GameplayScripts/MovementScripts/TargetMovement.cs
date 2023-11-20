using UnityEngine;

public class TargetMovement : MonoBehaviour // Este script se encarga de mover los objetos de las Piscina de Objetos
{
    [SerializeField] private Rigidbody rb;

    public float Speed = 2f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.velocity = Vector2.right * Speed;
    }
}
