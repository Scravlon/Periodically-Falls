using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    SpriteRenderer spr;
  
    private Sprite[] atomSprites;

    private int sprNumber;
    public float fallSpeed;
    public float MoveSpeed; //movement speed
    private Rigidbody2D rd;
    public AudioClip popSound;
    private AudioSource audioSource;
    public Transform prefab;
    public GameObject prefebObj;

    //  public Sprite[] atomSprites;




    private int atomState;
    // Use this for initialization


    void Start () {
        spr = GetComponent<SpriteRenderer>();
        atomState = 0;
        rd = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();

        atomSprites = Resources.LoadAll<Sprite>("atom");
    }


    void moveAtom()
    {
        if (Input.acceleration.x < 0 || (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") < 0))
        {
            rd.velocity = new Vector2(rd.velocity.x - MoveSpeed, rd.velocity.y);
            //Vector3 target = new Vector3(transform.position.x - MoveSpeed, transform.position.y, transform.position.z);
            //transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime);
           
        } else if (Input.acceleration.x > 0 || (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") > 0))
        {

            rd.velocity = new Vector2(rd.velocity.x + MoveSpeed, rd.velocity.y);
           // Vector3 target = new Vector3(transform.position.x + MoveSpeed, transform.position.y, transform.position.z);
           // transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime);

        }
        else if (Input.acceleration.x == 0)
        {
            
            rd.velocity = new Vector2(rd.velocity.x, rd.velocity.y);
        }
    }
    // Update is called once per frame
    void Update () {
        moveAtom();
        Vector3 target = new Vector3(transform.position.x, transform.position.y - (atomState +1)/10f, transform.position.z);
        PlayerPrefs.SetInt("atomState", atomState);
        transform.position = Vector3.MoveTowards(transform.position, target, fallSpeed + (atomState/100.0f+0.01f));
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Matter")
        {
            checkAndAdd();
            audioSource.PlayOneShot(popSound, 1f);
        } else if (collision.tag == "antiMatter")
        {
            checkAndMinus();
            audioSource.PlayOneShot(popSound, 1f);

        }
        else if (collision.tag == "voidMatter")
        {
            gameObject.SetActive(false);
            audioSource.PlayOneShot(popSound, 1f);

        } else if (collision.tag == "generate")
        {
            // Instantiate(prefebObj, transform);
            GameObject instance = Instantiate(Resources.Load("eas1", typeof(GameObject))) as GameObject;
            instance.transform.position = new Vector3(instance.transform.position.x, transform.position.y-5f, instance.transform.position.z);
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
    }
}
