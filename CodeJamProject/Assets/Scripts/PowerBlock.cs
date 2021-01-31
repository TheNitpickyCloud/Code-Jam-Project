using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PowerBlock : MonoBehaviour
{
    public static float power;
    public TMP_Text powerDisplay;
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
            FindObjectOfType<AudioManager>().Play("collectible-pickup");
            power++;
            //powerDisplay.text = power.ToString();
            Destroy(gameObject);
        }
    }
}
