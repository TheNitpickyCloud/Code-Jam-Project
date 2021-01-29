using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Assistant : MonoBehaviour
{
    public GameObject[] lavablocks;
    public TMP_Text powerDisplay;
    float index = 0;
    public ParticleSystem destroyEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        powerDisplay.text = (PowerBlock.power).ToString();
    }
    public void OnHelp()
    {
        if(PowerBlock.power > 0)
        {
            Destroy(lavablocks[(int)index]);
            destroyEffect.transform.position = lavablocks[(int)index].transform.position;
            PowerBlock.power--;
            index++;
            destroyEffect.gameObject.SetActive(true);
            destroyEffect.Play();
            //powerDisplay.text = PowerBlock.power.ToString();
        }
    }
}
