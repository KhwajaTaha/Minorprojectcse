using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamewin : MonoBehaviour
{
    public GameObject gamewincanvas;
    private void Start()
    {
        gamewincanvas.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            gamewincanvas.SetActive(true);
        }
    }
}
