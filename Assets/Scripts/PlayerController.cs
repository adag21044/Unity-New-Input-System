using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerControls playerControls;
    private Vector3 moveDirection;
    public float moveSpeed = 5f;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    private void Update()
    {
        Vector2 moveInput = playerControls.Land.Move.ReadValue<Vector2>();
        moveDirection = new Vector3(moveInput.x, moveInput.y, 0f);

        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        if (playerControls.Land.Jump.triggered)
        {
            Debug.Log("Jump");
        }
    }
}