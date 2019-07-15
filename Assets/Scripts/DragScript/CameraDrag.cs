using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDrag : MonoBehaviour {
    public Transform playerAtom;
    public GameObject playerObj;
    public GameObject endGame;
    public float endSpeed;
    public float endDelay;
    public float fallSpeed;
    public int atomStates;
    public int startGame;

    void Start()
    {
        atomStates = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount == 1)
        {
            startGame =1;
        }
        if (startGame >= 1) {

        if (playerObj.activeSelf)
        {
            Vector3 target = new Vector3(transform.position.x, transform.position.y - (atomStates + 1) / 10f, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, target, fallSpeed + (atomStates / 100.0f + 0.02f));
            endSpeed = 0;
        }
        else if (endSpeed <= 5 && !playerObj.activeSelf)
        {
            transform.position = new Vector3(transform.position.x, playerAtom.position.y - endSpeed, transform.position.z);
            endSpeed = endSpeed + endDelay;
            //GUI POP UP
            endGame.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            endGame.SetActive(true);

        }
    }


     

    }

}
