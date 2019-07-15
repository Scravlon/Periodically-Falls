using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoreText : MonoBehaviour {

    public GameObject playerAtom;
    Text txt;
    float currentDis;
    float score;
    // Use this for initialization
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        currentDis = Mathf.Abs(Mathf.Round(playerAtom.transform.position.y * 10) / 10);
        score = Mathf.Round((PlayerPrefs.GetInt("atomState") * currentDis + currentDis)*10)/10;
        txt.text = score.ToString();
    }
}
