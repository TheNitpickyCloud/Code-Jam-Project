using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaBlock : MonoBehaviour
{
    public GameObject endPanel;
    public GameObject pauseMenu;
    public GameObject pauseButton;
    public ParticleSystem destroyEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D player)
    {
        //play lava effect
        if(player.CompareTag("Player"))
        {
            destroyEffect.gameObject.SetActive(true);
            destroyEffect.transform.position = player.transform.position;
            Destroy(player.gameObject);
            destroyEffect.Play();
            endPanel.SetActive(true);
        }
    }
}
