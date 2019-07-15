using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDrag : MonoBehaviour {

    SpriteRenderer spr;

    private Sprite[] atomSprites;
    public float speed;
    private int sprNumber;
    public float fallSpeed;
    public float MoveSpeed; //movement speed
    public AudioClip popSound;
    private AudioSource audioSource;
    public Transform prefab;
    public GameObject prefebObj;
    private int atomState;
    public float step;
    public GameObject objCamera;




    // Use this for initialization



    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        atomState = 0;
        audioSource = GetComponent<AudioSource>();
        atomSprites = Resources.LoadAll<Sprite>("atom");
    }


    void moveAtom()
    {
        if (Input.touchCount == 1)
        {
            Vector3 pos = Input.GetTouch(0).position;
            pos.z = 0f;
            Vector3 realWorldPos = Camera.main.ScreenToWorldPoint(pos);
            realWorldPos.z = 0f;
            transform.position = Vector3.MoveTowards(transform.position, realWorldPos, step);

        }
    }
    // Update is called once per frame
    void Update()
    {
        moveAtom();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Matter")
        {
            checkAndAdd();
            PlayerPrefs.SetInt("atomState", atomState);

            audioSource.PlayOneShot(popSound, 1f);
        }
        else if (collision.tag == "antiMatter")
        {
            checkAndMinus();
            PlayerPrefs.SetInt("atomState", atomState);

            audioSource.PlayOneShot(popSound, 1f);

        }
        else if (collision.tag == "voidMatter")
        {
            PlayerPrefs.SetInt("atomState", atomState);
            gameObject.SetActive(false);             
            audioSource.PlayOneShot(popSound, 1f);

        }
        else if (collision.tag == "generate")
        {
            GameObject instance = Instantiate(Resources.Load("eas1Drag", typeof(GameObject))) as GameObject;
            instance.transform.position = new Vector3(instance.transform.position.x, transform.position.y - 5f, instance.transform.position.z);
        }
        //|| collision == "Enemy"


    }

    void checkAndMinus()
    {
        switch (atomState)
        {
            case 0:
                gameObject.SetActive(false);           
                break;
            case 1:
                spr.sprite = atomSprites[0];
                atomState--;
                break;
            case 2:
                spr.sprite = atomSprites[1];
                atomState--;
                break;
            case 3:
                spr.sprite = atomSprites[2];
                atomState--;
                break;
            case 4:
                spr.sprite = atomSprites[3];
                atomState--;
                break;
            case 5:
                spr.sprite = atomSprites[4];
                atomState--;
                break;
            case 6:
                spr.sprite = atomSprites[5];
                atomState--;
                break;
            case 7:
                spr.sprite = atomSprites[6];
                atomState--;
                break;
            case 8:
                spr.sprite = atomSprites[7];
                atomState--;
                break;
            case 9:
                spr.sprite = atomSprites[8];
                atomState--;
                break;
            case 10:
                spr.sprite = atomSprites[9];
                atomState--;
                break;
            case 11:
                spr.sprite = atomSprites[10];
                atomState--;
                break;
            case 12:
                spr.sprite = atomSprites[11];
                atomState--;
                break;
            case 13:
                spr.sprite = atomSprites[12];
                atomState--;
                break;
            case 14:
                spr.sprite = atomSprites[13];
                atomState--;
                break;
            case 15:
                spr.sprite = atomSprites[14];
                atomState--;
                break;
            case 16:
                spr.sprite = atomSprites[15];
                atomState--;
                break;
            case 17:
                spr.sprite = atomSprites[16];
                atomState--;
                break;
            case 18:
                spr.sprite = atomSprites[17];
                atomState--;
                break;
            case 19:
                spr.sprite = atomSprites[18];
                atomState--;
                break;
            case 20:
                spr.sprite = atomSprites[19];
                atomState--;
                break;
        }
        objCamera.GetComponent<CameraDrag>().atomStates = atomState;

    }
    void checkAndAdd()
    {
        switch (atomState)
        {
            case 0:
                spr.sprite = atomSprites[1];
                atomState++;
                break;
            case 1:
                spr.sprite = atomSprites[2];
                atomState++;
                break;
            case 2:
                spr.sprite = atomSprites[3];
                atomState++;
                break;
            case 3:
                spr.sprite = atomSprites[4];
                atomState++;
                break;
            case 4:
                spr.sprite = atomSprites[5];
                atomState++;
                break;
            case 5:
                spr.sprite = atomSprites[6];
                atomState++;
                break;
            case 6:
                spr.sprite = atomSprites[7];
                atomState++;
                break;
            case 7:
                spr.sprite = atomSprites[8];
                atomState++;
                break;
            case 8:
                spr.sprite = atomSprites[9];
                atomState++;
                break;
            case 9:
                spr.sprite = atomSprites[10];
                atomState++;
                break;
            case 10:
                spr.sprite = atomSprites[11];
                atomState++;
                break;
            case 11:
                spr.sprite = atomSprites[12];
                atomState++;
                break;
            case 12:
                spr.sprite = atomSprites[13];
                atomState++;
                break;
            case 13:
                spr.sprite = atomSprites[14];
                atomState++;
                break;
            case 14:
                spr.sprite = atomSprites[15];
                atomState++;
                break;
            case 15:
                spr.sprite = atomSprites[16];
                atomState++;
                break;
            case 16:
                spr.sprite = atomSprites[17];
                atomState++;
                break;
            case 17:
                spr.sprite = atomSprites[18];
                atomState++;
                break;
            case 18:
                spr.sprite = atomSprites[19];
                atomState++;
                break;
            case 19:
                spr.sprite = atomSprites[20];
                atomState++;
                break;

        }
        objCamera.GetComponent<CameraDrag>().atomStates = atomState;

    }
}
