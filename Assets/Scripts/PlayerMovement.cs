using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce = 500;
    public float sideForce = 500;
    public Rigidbody rb;

    void Start()
    {
    }

    void FixedUpdate()
    {
        // Applying a forward force to player object
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        bool keyLeft = Input.GetKey("a");
        bool keyRight = Input.GetKey("d");

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

        if (rb.position.y < -10f || rb.position.y > 10f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
