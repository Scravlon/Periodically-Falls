using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quitCTRL : MonoBehaviour{

    public void LoadScene(string scenneName)
    {
        Application.Quit();
    }
}
