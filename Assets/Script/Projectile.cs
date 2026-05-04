using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.zero; // รีเซ็ตก่อนยิงใหม่
            rb.AddForce(new Vector2(5f, 10f), ForceMode2D.Impulse);
        }
    }
}
