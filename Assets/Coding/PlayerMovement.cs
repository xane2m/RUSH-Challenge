using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float jumpForce = 500.0f;
    public Rigidbody rb;
    public Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // Handle WASD movement
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(moveX, 0.0f, moveY);
        rb.AddForce(movement * moveSpeed);
        // Handle jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
        // Handle animations
        anim.SetFloat("HorizontalWalking", moveX);
        anim.SetFloat("VerticalMovement", moveY);
    }
}