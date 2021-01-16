using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Assistant : MonoBehaviour
{
    public GameObject[] lavablocks;
    public TMP_Text powerDisplay;
    float index = 0;
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
            PowerBlock.power--;
            index++;
            //powerDisplay.text = PowerBlock.power.ToString();
        }
    }
}
