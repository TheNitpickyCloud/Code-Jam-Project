using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("music");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("level-change");
            PlayButtons.level3unlocked = true;
            ES3.Save<bool>("level3", PlayButtons.level3unlocked);
            SceneManager.LoadScene("Level3");
        }
    }
}
