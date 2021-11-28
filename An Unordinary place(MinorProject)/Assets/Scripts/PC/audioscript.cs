using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioscript : MonoBehaviour
{
    public AudioSource sound;
    public bool isplaying = true;
    public GameObject onbutton;
    public GameObject ofbutton;
    
    
    
    public void playsound()
    {
        
         sound.Pause();
         onbutton.SetActive(false);
         ofbutton.SetActive(true);
            
        
    }
    public void pausesound()
    {
        
        
            sound.Play();
            ofbutton.SetActive(false);
            onbutton.SetActive(true);
        
        }
}
