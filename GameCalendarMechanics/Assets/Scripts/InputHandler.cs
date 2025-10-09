using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public PlayerController CharacterController; // Reference to character player controller component
    private InputAction moveAction, jumpAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");

        jumpAction = InputSystem.actions.FindAction("Jump"); // button subscribe, not a vector
        jumpAction.performed += OnJump;

        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementVector = moveAction.ReadValue<Vector2>();
        CharacterController.Move(movementVector);
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        CharacterController.Jump();
    }
}
