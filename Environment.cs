using UnityEngine;
using UnityEngine.SceneManagement;
public class Environment : MonoBehaviour
{
    public void Morning()
    {
        SceneManager.LoadScene("Morning");
    }

    public void Afternoon()
    {
        SceneManager.LoadScene("Afternoon");
    }

    public void Night()
    {
        SceneManager.LoadScene("Night");
    }

    public void Mars()
    {
        SceneManager.LoadScene("Mars");
    }

    public void Space()
    {
        SceneManager.LoadScene("Space");
    }

    public void BacktoMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
