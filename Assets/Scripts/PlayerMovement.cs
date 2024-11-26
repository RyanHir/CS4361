using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce = 2000f;
    public float sideForce = 100f;
    public float jumpForce = 6.5f; // Force for jumping
    public Rigidbody rb;
    public LayerMask groundMask; // Layer to check if player is grounded
    private bool isGrounded;

    void Start()
    {
        // Ensure the Rigidbody reference is set
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }

        groundMask = LayerMask.GetMask("Ground");
    }

    void Update()
    {
        // Check if grounded before allowing jump
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f, groundMask);

        // Jumping functionality with "Space" key
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        // Applying a forward force to player object
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Movement with both "A/D" and "LeftArrow/RightArrow" keys
        bool keyLeft = Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow);
        bool keyRight = Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow);

        if (keyLeft || keyRight)
        {
            if (keyRight)
            {
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else if (keyLeft)
            {
                rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        // Check if the player is out of bounds (e.g., falling off the platform)
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}