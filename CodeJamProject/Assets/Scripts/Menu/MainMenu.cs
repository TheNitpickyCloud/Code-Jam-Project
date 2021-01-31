using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject levelSelector;
    public GameObject playerTexture;
    // Start is called before the first frame update
    void Start()
    {/*
        ES3.DeleteKey("level1");
        ES3.DeleteKey("level2");
        ES3.DeleteKey("level3");
        ES3.DeleteKey("level4");
        ES3.DeleteKey("level5");
        ES3.DeleteKey("level6");
        ES3.DeleteKey("level7");
        ES3.DeleteKey("level8");
        ES3.DeleteKey("level9");
        ES3.DeleteKey("level10");
    */
        FindObjectOfType<AudioManager>().Play("music");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PlayLevel()
    {
        //playerTexture.SetActive(false);
        levelSelector.SetActive(true);
    }

    public void QuitGame() 
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
    public void BackButton()
    {
        levelSelector.SetActive(false);
    }
}
