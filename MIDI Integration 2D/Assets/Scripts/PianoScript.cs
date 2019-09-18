using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoScript : MonoBehaviour
{

    //particlesystem
    public ParticleSystem keyTrigger;

    [SerializeField]private float Yincrement = 0.01f;
    private Vector2 targetPos;

    AudioSource Keys;
    public AudioClip KeysClip;

    //Inputs range from 0-11 and represent chromatic scale starting on C, with C representing 0

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("C"))
        {
            if (Input.GetKeyUp(KeyCode.Keypad0)) //C
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("C_Sharp"))
        {
            if (Input.GetKeyUp(KeyCode.Keypad1)) //C#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("D"))
        {
            if (Input.GetKeyUp(KeyCode.Keypad2)) //D
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("D_Sharp"))
        {
            if (Input.GetKeyUp(KeyCode.Keypad3)) //D#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("E"))
        {
            if (Input.GetKeyUp(KeyCode.Keypad4)) //E
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("F"))
        {
            if (Input.GetKeyUp(KeyCode.Keypad5)) //F
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("F_Sharp"))
        {
            if (Input.GetKeyUp(KeyCode.Keypad6)) //F#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("G"))
        {
            if (Input.GetKeyUp(KeyCode.Keypad7)) //G
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("G_Sharp"))
        {
            if (Input.GetKeyUp(KeyCode.Keypad8)) //G#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("A"))
        {
            if (Input.GetKeyUp(KeyCode.Keypad9)) //A
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("A_Sharp"))
        {
            if (Input.GetKeyUp(KeyCode.T)) //A#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("B"))
        {
            if (Input.GetKeyUp(KeyCode.E)) //B
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("C_5"))
        {
            if (Input.GetKeyUp(KeyCode.C)) //B
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
    }
}
