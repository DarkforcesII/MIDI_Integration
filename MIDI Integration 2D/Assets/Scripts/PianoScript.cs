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
        // Don't destroy the script
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("C"))
        {
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 60) || Input.GetKeyUp(KeyCode.Keypad0)) //C
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("C_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 61) || Input.GetKeyUp(KeyCode.Keypad1)) //C#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("D"))
        {
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 62) || Input.GetKeyUp(KeyCode.Keypad2)) //D
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("D_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 63) || Input.GetKeyUp(KeyCode.Keypad3)) //D#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("E"))
        {
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 64) || Input.GetKeyUp(KeyCode.Keypad4)) //E
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("F"))
        {
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 65) || Input.GetKeyUp(KeyCode.Keypad5)) //F
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("F_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 66) || Input.GetKeyUp(KeyCode.Keypad6)) //F#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("G"))
        {
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 67) || Input.GetKeyUp(KeyCode.Keypad7)) //G
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("G_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 68) || Input.GetKeyUp(KeyCode.Keypad8)) //G#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("A"))
        {
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 69) || Input.GetKeyUp(KeyCode.Keypad9)) //A
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("A_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 70) || Input.GetKeyUp(KeyCode.T)) //A#
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("B"))
        {
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 71) || Input.GetKeyUp(KeyCode.E)) //B
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("C_5"))
        {
            if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 72) || Input.GetKeyUp(KeyCode.C)) //C
            {
                keyTrigger.Emit(1);
                GetComponent<AudioSource>().PlayOneShot(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
    }
}
