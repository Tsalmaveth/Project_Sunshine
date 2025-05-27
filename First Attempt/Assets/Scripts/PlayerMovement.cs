using UnityEngine;
using Unity.VisualScripting;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpForce = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get movement input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        moveDirection.Normalize(); // Normalize to prevent faster diagonal movement

        // Apply movement
        Vector3 move = moveDirection * moveSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + move);

        // Apply jump
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
