using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuAtom : MonoBehaviour {

    private SpriteRenderer sprite;
    private int atomState = 0;
    private Sprite[] atomSprites;

    // Use this for initialization
    void Start () {
        sprite = GetComponent<SpriteRenderer>();
        atomSprites = Resources.LoadAll<Sprite>("atom");

        if (PlayerPrefs.GetInt("atomState") == 0)
        {

        }
        else
        {
            atomState = PlayerPrefs.GetInt("atomState");
        }
        sprite.sprite = atomSprites[atomState];
        transform.localScale.Set(0.1f, 0.1f, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
