using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuCtRL : MonoBehaviour {

    private AudioSource audioSource;
    public GameObject settingGUI;
    public GameObject buttonToDisable;
    public GameObject Mute_Text;

   

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        checkMute();


    }
    public void LoadScene(string scenneName)
    {
        if (scenneName == "quit")
        {
            Application.Quit();
            print("Quited");
        } else
        {
            SceneManager.LoadScene(scenneName);
        }
    }
    
    public void playMenuSound()
    {
        audioSource.Play();
    }

    public void settingMenu()
    {
        settingGUI.SetActive(true);
        buttonToDisable.SetActive(false);
    }

    public void closeSetting()
    {
        settingGUI.SetActive(false);
        buttonToDisable.SetActive(true);
    }

    public void muteSound()
    {
        print(PlayerPrefs.GetInt("mute"));
        if (PlayerPrefs.GetInt("mute") == 0)
        {
            PlayerPrefs.SetInt("mute", 1);

        } else if (PlayerPrefs.GetInt("mute") == 1)
        {
            PlayerPrefs.SetInt("mute", 0);
        }
        checkMute();
    }

    public void checkMute()
    {
        if (PlayerPrefs.GetInt("mute") == 0)
        {
            AudioListener.pause = false;
            Mute_Text.GetComponent<UnityEngine.UI.Text>().text = "Mute";

        }
        else if (PlayerPrefs.GetInt("mute") == 1)
        {
            AudioListener.pause = true;
            Mute_Text.GetComponent<UnityEngine.UI.Text>().text = "Unute";
        }
    }

}
