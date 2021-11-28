using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoothcamerafollow : MonoBehaviour
{


    private Transform Player;

    private void Start()
    {
        
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        
            Vector3 temp = transform.position;

                    temp.x = Player.position.x;

                    transform.position = temp;
        
        
    }
}