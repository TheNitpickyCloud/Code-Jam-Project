using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    public void pauseButton() 
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    void Start()
    {
        Time.timeScale = 1f;
    }
    public void Resume() 
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void Restart() 
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
;    }

    public void QuitGame() 
    {
        Time.timeScale = 1f;
        Application.Quit();
    }

}
