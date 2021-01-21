using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ES3Internal;
public class Level1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.CompareTag("Player"))
        {
            PlayButtons.level2unlocked = true;
            ES3.Save<bool>("level2", PlayButtons.level2unlocked);
            SceneManager.LoadScene("Level2");
        }
    }
}
