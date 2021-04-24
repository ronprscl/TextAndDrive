using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    SpriteRenderer SR;
    Rigidbody2D rb;
    float speed;
    public Sprite turnLeftSprite, turnRightSprite, idleSprite;
    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(Mathf.Lerp(rb.velocity.x, speed, 0.05f), 1);
            SR.sprite = turnRightSprite;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(Mathf.Lerp(rb.velocity.x, -speed, 0.05f), 1);
            SR.sprite = turnLeftSprite;
        }
        else
        {
            rb.velocity = new Vector2(Mathf.Lerp(rb.velocity.x, 0, 0.05f), 1);
            SR.sprite = idleSprite;
        }
        transform.up = new Vector2(rb.velocity.x * 0.02f, rb.velocity.y);
       
    }
}
