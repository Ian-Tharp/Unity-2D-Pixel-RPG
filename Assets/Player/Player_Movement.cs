using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 Movement;

    // Update is called once per frame
    void Update()
    {
        //User input
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Veritcal");
    }

    void FixedUpdate()
    {
        //Player movement
        rb.MovePosition(rb.position + Movement.x * moveSpeed * Time.fixedDeltaTime);
        //rb.MovePosition(rb.position + Movement.y * moveSpeed * Time.fixedDeltaTime);
    }
}
