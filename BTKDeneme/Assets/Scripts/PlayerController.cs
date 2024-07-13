using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float moveSpeed = 1.0f;
    bool facingRight = true;

    void Awake()
    {
        print("AWAKE metodu çalýþtý");
    }

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, playerRB.velocity.y);
        if (playerRB.velocity.x < 0 && facingRight) {
            FlipFace();
        } else if (playerRB.velocity.x > 0 && !facingRight) {
            FlipFace();
        }
    }

    void fixedUpdate()
    {

    }
    void HorizonalMove()
    {
        //playerRB.velocity = new Vector2(Input.GetAxis("Horizontal"),);
    }
    void FlipFace()
    {
        facingRight = !facingRight;
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x *= -1;
        transform.localScale = tempLocalScale;
    }
}
