using UnityEngine;

public class hingeScript : MonoBehaviour
{
    Rigidbody2D rb;

    public float moveSpeed = 50f;
    public float rightAngle = 45f;
    public float leftAngle = -45f;

    bool moveClockwise = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        float currentAngle = rb.rotation;

        if (currentAngle >= rightAngle)
            moveClockwise = false;

        if (currentAngle <= leftAngle)
            moveClockwise = true;

        rb.angularVelocity = moveClockwise ? moveSpeed : -moveSpeed;
    }
}
