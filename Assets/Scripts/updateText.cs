using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateText : MonoBehaviour {

    public GameObject playerAtom;
    Text txt;
    // Use this for initialization
	void Start () {
        txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        txt.text =  Mathf.Abs(Mathf.Round(playerAtom.transform.position.y * 10)/10) + "nm";		
	}
}
