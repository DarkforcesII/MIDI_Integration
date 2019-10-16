using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class GeneralPianoScript : MonoBehaviour
{
    [SerializeField] private AudioClip[] keyClips;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60) || Input.GetKeyUp(KeyCode.Keypad0)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[0]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 61) || Input.GetKeyUp(KeyCode.Keypad1)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[1]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 62) || Input.GetKeyUp(KeyCode.Keypad2)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[2]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 63) || Input.GetKeyUp(KeyCode.Keypad3)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[3]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 64) || Input.GetKeyUp(KeyCode.Keypad4)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[4]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 65) || Input.GetKeyUp(KeyCode.Keypad5)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[5]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 66) || Input.GetKeyUp(KeyCode.Keypad6)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[6]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 67) || Input.GetKeyUp(KeyCode.Keypad7)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[7]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 68) || Input.GetKeyUp(KeyCode.Keypad8)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[8]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69) || Input.GetKeyUp(KeyCode.Keypad9)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[9]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 70) || Input.GetKeyUp(KeyCode.T)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[10]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 71) || Input.GetKeyUp(KeyCode.E)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[11]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 72) || Input.GetKeyUp(KeyCode.E)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[12]);
        }
    }
}
