using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce = 500;
    public float sideForce = 500;
    public Rigidbody rb;

    void Start()
    {
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        // Applying a forward force to player object
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        const bool keyLeft = Input.GetKey("a"); 
        const bool keyRight = Input.GetKey("d"); 

        if (keyLeft || keyRight)
        {
            if (keyRight)
            {
                rb.AddForce(sideForce * Time.deltaTime, 0, 0);
            }
            else if (keyLeft)
            {
                rb.AddForce(-sideForce * Time.deltaTime, 0, 0);

            }
        }
    }
}
