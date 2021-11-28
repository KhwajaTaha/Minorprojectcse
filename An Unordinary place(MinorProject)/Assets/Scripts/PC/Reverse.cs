using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reverse : MonoBehaviour
{
    public Animator reverseanimation;
    public GameObject transition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ChangeScene());
            reverseanimation.Play("Reverse");
            
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transition != null)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                transition.SetActive(true);
                StartCoroutine(lastScene());
            }
        }
        else
            return;
        
    }

    IEnumerator lastScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(2);
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
}
