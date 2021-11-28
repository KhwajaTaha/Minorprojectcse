using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 300;
    public bool isjump = false;
    public Rigidbody2D characterBody;
    private float ScreenWidth;
    public GameObject spikes;
    public GameObject spikesbutton;
    // Use this for initialization    
    void Start()
    {
       spikes.SetActive(false);
        ScreenWidth = Screen.width;
       
    }
    // Update is called once per frame    
    void Update()
    {
        if (isjump == false)
        {
            int i = 0;
            //loop over every touch found    
            while (i < Input.touchCount)
            {


                if (Input.GetTouch(i).position.x > ScreenWidth / 2)
                {
                    //move right    
                    RunCharacter(1.0f);
                    gameObject.GetComponent<SpriteRenderer>().flipX = false;
                    Debug.Log("in");

                }
                if (Input.GetTouch(i).position.x < ScreenWidth / 2)
                {
                    //move left    
                    RunCharacter(-1.0f);
                    gameObject.GetComponent<SpriteRenderer>().flipX = true;

                }

                ++i;
            }
        }
    }
    void FixedUpdate()
    {
#if UNITY_EDITOR
        RunCharacter(Input.GetAxis("Horizontal"));
#endif
    }
    private void RunCharacter(float horizontalInput)
    {
        //move player    
       
        characterBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));
    }
    public void jump()
    {
        isjump = true;
        characterBody.AddForce(transform.up * 300);
        isjump = false;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("spikebutton"))
        {
            spikesbutton.transform.position = new Vector2(transform.position.x, -3.743f);
            spikes.SetActive(true);
        }
    }
}
