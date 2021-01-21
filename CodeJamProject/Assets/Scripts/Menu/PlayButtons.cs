using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using ES3Internal;
public class PlayButtons : MonoBehaviour
{
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;

    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public Image image7;
    public Image image8;
    public Image image9;
    public Image image10;


    public static bool level2unlocked = false;
    public static bool level3unlocked = false;
    public static bool level4unlocked = false;
    public static bool level5unlocked = false;
    public static bool level6unlocked = false;
    public static bool level7unlocked = false;
    public static bool level8unlocked = false;
    public static bool level9unlocked = false;
    public static bool level10unlocked = false;
    // Start is called before the first frame update
    void Start()
    {
        button2.enabled = false;
        button3.enabled = false;
        button4.enabled = false;
        button5.enabled = false;
        button6.enabled = false;
        button7.enabled = false;
        button8.enabled = false;
        button9.enabled = false;
        button10.enabled = false;

        level2unlocked = ES3.Load<bool>("level2", false);
        level3unlocked = ES3.Load<bool>("level3", false);
        level4unlocked = ES3.Load<bool>("level4", false);
        level5unlocked = ES3.Load<bool>("level5", false);
        level6unlocked = ES3.Load<bool>("level6", false);
        level7unlocked = ES3.Load<bool>("level7", false);
        level8unlocked = ES3.Load<bool>("level8", false);
        level9unlocked = ES3.Load<bool>("level9", false);
        level10unlocked = ES3.Load<bool>("level10", false);

        if(level2unlocked == true)
        {
            button2.enabled = true; 
            image2.gameObject.SetActive(false);
        }

        if(level3unlocked == true)
        {
            button3.enabled = true;
            image3.gameObject.SetActive(false); 
        }

        if(level4unlocked == true)
        {
            button4.enabled = true;
            image4.gameObject.SetActive(false); 
        }

        if(level5unlocked == true)
        {
            button5.enabled = true;
            image5.gameObject.SetActive(false); 
        }

        if(level6unlocked == true)
        {
            button6.enabled = true;
            image6.gameObject.SetActive(false); 
        }

        if(level7unlocked == true)
        {
            button7.enabled = true;
            image7.gameObject.SetActive(false); 
        }

        if(level8unlocked == true)
        {
            button8.enabled = true; 
            image8.gameObject.SetActive(false);
        }

        if(level9unlocked == true)
        {
            button9.enabled = true;
            image9.gameObject.SetActive(false); 
        }

        if(level10unlocked == true)
        {
            button10.enabled = true;
            image10.gameObject.SetActive(false); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(level2unlocked == true)
        {
            button2.enabled = true; 
            image2.gameObject.SetActive(false);
        }

        if(level3unlocked == true)
        {
            button3.enabled = true;
            image3.gameObject.SetActive(false); 
        }

        if(level4unlocked == true)
        {
            button4.enabled = true;
            image4.gameObject.SetActive(false); 
        }

        if(level5unlocked == true)
        {
            button5.enabled = true;
            image5.gameObject.SetActive(false); 
        }

        if(level6unlocked == true)
        {
            button6.enabled = true;
            image6.gameObject.SetActive(false); 
        }

        if(level7unlocked == true)
        {
            button7.enabled = true;
            image7.gameObject.SetActive(false); 
        }

        if(level8unlocked == true)
        {
            button8.enabled = true; 
            image8.gameObject.SetActive(false);
        }

        if(level9unlocked == true)
        {
            button9.enabled = true;
            image9.gameObject.SetActive(false); 
        }

        if(level10unlocked == true)
        {
            button10.enabled = true;
            image10.gameObject.SetActive(false); 
        }
    }

    public void level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void level3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void level4()
    {
        SceneManager.LoadScene("Level4");
    }
    public void level5()
    {
        SceneManager.LoadScene("Level5");
    }
    public void level6()
    {
        SceneManager.LoadScene("Level6");
    }
    public void level7()
    {
        SceneManager.LoadScene("Level7");
    }
    public void level8()
    {
        SceneManager.LoadScene("Level8");
    }
    public void level9()
    {
        SceneManager.LoadScene("Level9");
    }

}
