using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float moveSpeed = 5f;

	public Rigidbody2D rb;


    Vector2 movement;
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        //Movement
        rb.linearVelocity = movement * moveSpeed * Time.fixedDeltaTime;
    }
}
