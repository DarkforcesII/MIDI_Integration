using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class PianoScript : MonoBehaviour
{

    //particlesystem
    public ParticleSystem keyTrigger;

    [SerializeField] private float Yincrement = 0.01f;
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
            /*if (Input.GetKeyUp(KeyCode.Keypad0))*/
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 60)) //C
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("C_Sharp"))
        {
            /*if (Input.GetKeyUp(KeyCode.Keypad1))*/
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 61)) //C#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("D"))
        {
            /*if (Input.GetKeyUp(KeyCode.Keypad2))*/
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 62)) //D
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("D_Sharp"))
        {
            /*if (Input.GetKeyUp(KeyCode.Keypad3))*/
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 63)) //D#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("E"))
        {
            /*if (Input.GetKeyUp(KeyCode.Keypad4))*/
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 64)) //E
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("F"))
        {
            /*if (Input.GetKeyUp(KeyCode.Keypad5))*/
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 65)) //F
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("F_Sharp"))
        {
            /*if (Input.GetKeyUp(KeyCode.Keypad6))*/
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 66)) //F#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("G"))
        {
            /*if (Input.GetKeyUp(KeyCode.Keypad7))*/
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 67)) //G
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("G_Sharp"))
        {
            /*if (Input.GetKeyUp(KeyCode.Keypad8))*/
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 68)) //G#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("A"))
        {
            /*if (Input.GetKeyUp(KeyCode.Keypad9))*/
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 69)) //A
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("A_Sharp"))
        {
            /*if (Input.GetKeyUp(KeyCode.T))*/
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 70)) //A#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("B"))
        {
            /*if (Input.GetKeyUp(KeyCode.E))*/
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 71)) //B
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("C_5"))
        {
            /*if (Input.GetKeyUp(KeyCode.C))*/
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 72)) //C
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
    }
}
