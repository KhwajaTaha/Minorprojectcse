using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamewincanvas : MonoBehaviour
{
    public string leveload;
    public void nextlevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(leveload);
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(leveload);
    }
    public void Quit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(leveload);
    }

}
