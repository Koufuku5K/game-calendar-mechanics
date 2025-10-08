using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    public float movementSpeed = 10f, rotationSpeed = 5f;
    private float rotationY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void Move(Vector2 movementVector)
    {
        Vector3 move = transform.forward * movementVector.y + transform.right * movementVector.x;
        move = move * movementSpeed * Time.deltaTime;
        characterController.Move(move);
    }
    
    public void Rotate(Vector2 rotationVector)
    {
        rotationY += rotationVector.x * rotationSpeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0, rotationY, 0);
    }
}
