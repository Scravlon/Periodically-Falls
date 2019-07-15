using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCTRL : MonoBehaviour {

    public Transform playerAtom;
    public GameObject playerObj;
    public GameObject endGame;
    public float endSpeed;
    public float endDelay;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerObj.activeSelf)
        {
            transform.position = new Vector3(transform.position.x, playerAtom.position.y, transform.position.z);
            endSpeed = 0;
        }
        else if (endSpeed <= 5 && !playerObj.activeSelf)
        {
            transform.position = new Vector3(transform.position.x, playerAtom.position.y - endSpeed, transform.position.z);
            endSpeed = endSpeed + endDelay;
            //GUI POP UP
            endGame.transform.position = new Vector3(transform.position.x,transform.position.y,0);
            endGame.SetActive(true);

        }

       
            
          //  Instantiate(prefab, transform);
                //var instance : GameObject = Instantiate(Resources.Load("enemy"));
       


    }
}
