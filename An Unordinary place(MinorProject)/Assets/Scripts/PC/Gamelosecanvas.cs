using UnityEngine.SceneManagement;
using UnityEngine;

public class Gamelosecanvas : MonoBehaviour
{
    public string leveload;
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
