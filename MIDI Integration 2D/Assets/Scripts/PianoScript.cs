﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;
using UnityEngine.SceneManagement;

public class PianoScript : MonoBehaviour
{
    //particlesystem
    public ParticleSystem keyTrigger;

    [SerializeField] private float Yincrement = 0.01f;
    private Vector2 targetPos;

    private AudioSource Keys;
    [SerializeField] private AudioClip KeysClip;


    //Inputs range from 0-11 and represent chromatic scale starting on C, with C representing 0

    // Start is called before the first frame update
    void Start()
    {
        // Find scene
        Scene currentScene = SceneManager.GetActiveScene();
        // Retreive name of scene
        string sceneName = currentScene.name;
        if (sceneName == "Prototype")
        {
            DontDestroyOnLoad(this.gameObject);
        }

        // Don't destroy the script
        DontDestroyOnLoad(this.gameObject);
        /*audioClip1 = Resources.Load<AudioClip>("Audio/C#_4");*/ // save for later
}

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("C"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60) || Input.GetKeyUp(KeyCode.Keypad0)) //C
            {
                keyTrigger.Emit(1);
               AudioManager.Instance.PlaySFX(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("C_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 61) || Input.GetKeyUp(KeyCode.Keypad1)) //C#
            {
                keyTrigger.Emit(1);
                AudioManager.Instance.PlaySFX(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("D"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 62) || Input.GetKeyUp(KeyCode.Keypad2)) //D
            {
                keyTrigger.Emit(1);
                AudioManager.Instance.PlaySFX(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("D_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 63) || Input.GetKeyUp(KeyCode.Keypad3)) //D#
            {
                keyTrigger.Emit(1);
                AudioManager.Instance.PlaySFX(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("E"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 64) || Input.GetKeyUp(KeyCode.Keypad4)) //E
            {
                keyTrigger.Emit(1);
                AudioManager.Instance.PlaySFX(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("F"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 65) || Input.GetKeyUp(KeyCode.Keypad5)) //F
            {
                keyTrigger.Emit(1);
                AudioManager.Instance.PlaySFX(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("F_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 66) || Input.GetKeyUp(KeyCode.Keypad6)) //F#
            {
                keyTrigger.Emit(1);
                AudioManager.Instance.PlaySFX(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("G"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 67) || Input.GetKeyUp(KeyCode.Keypad7)) //G
            {
                keyTrigger.Emit(1);
                AudioManager.Instance.PlaySFX(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("G_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 68) || Input.GetKeyUp(KeyCode.Keypad8)) //G#
            {
                keyTrigger.Emit(1);
                AudioManager.Instance.PlaySFX(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("A"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69) || Input.GetKeyUp(KeyCode.Keypad9)) //A
            {
                keyTrigger.Emit(1);
                AudioManager.Instance.PlaySFX(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("A_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 70) || Input.GetKeyUp(KeyCode.T)) //A#
            {
                keyTrigger.Emit(1);
                AudioManager.Instance.PlaySFX(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("B"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 71) || Input.GetKeyUp(KeyCode.E)) //B
            {
                keyTrigger.Emit(1);
                AudioManager.Instance.PlaySFX(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
        if (gameObject.CompareTag("C_5"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 72) || Input.GetKeyUp(KeyCode.C)) //C
            {
                keyTrigger.Emit(1);
                AudioManager.Instance.PlaySFX(KeysClip);
                /*targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;*/
            }
        }
    }
}
