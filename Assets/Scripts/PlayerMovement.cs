using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;
    private float verticalSpeedLastFrame;
    public int jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        verticalSpeedLastFrame = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (Mathf.Floor(verticalSpeedLastFrame*1000)/1000) == 0 && (Mathf.Floor(rb.velocity.y*10000)/10000 == 0))
        {
            rb.AddForce(new Vector2(0, .8f) * jumpForce, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        verticalSpeedLastFrame = rb.velocity.y;
    }
}
