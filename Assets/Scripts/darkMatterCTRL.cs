using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darkMatterCTRL : MonoBehaviour
{

    public float horizontalSpeed;
    private bool moveDirec = true;
    private float speedRandom;

    // Use this for initialization
    void Start()
    {
        speedRandom = Random.value;
        if (speedRandom == 0)
        {
            speedRandom = 0.4f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -2.5)
        {
            moveDirec = true;

        }
        else if (transform.position.x > 2.5)
        {
            moveDirec = false;
        }

        if (moveDirec)
        {
            transform.position = new Vector3(transform.position.x + horizontalSpeed * speedRandom, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - horizontalSpeed * speedRandom, transform.position.y, transform.position.z);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameObject.SetActive(false);

        }
    }
}
