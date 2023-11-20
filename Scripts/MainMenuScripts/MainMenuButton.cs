using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void ChangeScene(int n)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(n);
    }

    public void ExitGame(int n)
    {
        Application.Quit(n);
    }

    public void ResetValues()
    {
        PlayerPrefs.DeleteAll();
    }
}
