using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brothers : MonoBehaviour
{
    public float movespeed = 5f;
    public bool isgrounded = false;
    float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * movespeed;
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isgrounded)
        {
            jumpForce = Random.Range(5, 15);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isgrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Clear"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isgrounded = true;
        }
    }


    }
