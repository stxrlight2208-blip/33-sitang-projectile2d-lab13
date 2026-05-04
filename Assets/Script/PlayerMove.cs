using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;

    Rigidbody2D rb;
    bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // เดินซ้ายขวา
        float move = 0;

        if (Input.GetKey(KeyCode.A))
            move = -1;
        else if (Input.GetKey(KeyCode.D))
            move = 1;

        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        // กระโดด
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    // เช็คว่าติดพื้น
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}