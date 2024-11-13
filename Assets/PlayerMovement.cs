using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const float FORWARD_FORCE = 500;
    public Rigidbody rb;

    void Start()
    {
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, FORWARD_FORCE * Time.deltaTime);
    }
}
