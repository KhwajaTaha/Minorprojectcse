using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 5f;
    public bool isgrounded;
    public GameObject gameovercanvas;

    public Animator CameraAnim;
    public GameObject EndingScreen;

   /* public GameObject[] Triggers;*/
    public GameObject[] Trig_Platforms;
    public int i = 0;
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
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse);
            isgrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameObject.GetComponent<PlayerMovement>().enabled = false;
            gameovercanvas.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isgrounded = true;
        }

        if (collision.gameObject.CompareTag("Trigger_Obs"))
        {
            Destroy(collision.gameObject);
            Destroy(Trig_Platforms[i]);
            i++;
        }
        
    }

    public GameObject Hints_1;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GameWin"))
        {
            gameWin();
        }

        if (collision.gameObject.CompareTag("Hints_1"))
        {
            Hints_1.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hints_1"))
        {
            Hints_1.SetActive(false);
        }
    }

    public void gameWin()
    {
        Camera.main.GetComponent<Smoothcamerafollow>().enabled = false;
        gameObject.GetComponent<PlayerMovement>().enabled = false;
        CameraAnim.Play("Ending");
        StartCoroutine(showCredits());
    }

    IEnumerator showCredits()
    {
        yield return new WaitForSeconds(3);
        EndingScreen.SetActive(true);
    }
    
}
