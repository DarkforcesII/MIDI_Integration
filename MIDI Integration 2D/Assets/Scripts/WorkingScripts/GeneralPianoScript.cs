﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class GeneralPianoScript : MonoBehaviour
{
    // 0-87(1-88) for piano 
    // 88 - for Electric Piano

    // TO Do: Add Color Functionality to the rest of the notes

    [SerializeField] private AudioClip[] keyClips;

    private int i = 4;
    private int voice = 100;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    
        Debug.Log("i = " + i);
        print("Piano");
    }

    // Octave Controller
    private void ChangeCounter()
    {
        // Moves Octave Down
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            i--;
            Debug.Log("i = " + i);
        }

        // Moves Octave Up
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            i++;
            Debug.Log("i = " + i);
        }
    }

    // Voice Controller
    private void ChangeVoice()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && voice == 100)
        {
            voice++;
            Debug.Log("ElePno" + voice);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && voice == 101)
        {
            voice--;
            Debug.Log("Pno" + voice);
        }
    }

    // Called in update so notes in this ocatave can be played
    private void Octave_0()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 21)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[0]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 22)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[1]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 23)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[2]);
        }
    }
    private void Octave_1()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 24)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[3]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 25)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[4]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 26)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[5]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 27)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[6]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 28)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[7]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 29)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[8]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 30)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[9]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 31)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[10]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 32)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[11]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 33)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[12]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 34)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[13]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 35)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[14]);
        }
    }
    private void Octave_2()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 36)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[15]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 37)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[16]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 38)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[17]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 39)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[18]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 40)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[19]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 41)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[20]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 42)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[21]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 43)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[22]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 44)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[23]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 45)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[24]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 46)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[25]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 47)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[26]);
        }
    }
    private void Octave_3()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 48)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[27]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 49)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[28]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 50)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[29]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 51)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[30]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 52)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[31]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 53)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[32]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 54)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[33]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 55)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[34]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 56)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[35]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 57)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[36]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 58)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[37]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 59)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[38]);
        }
    }
    private void Octave_4()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60) || Input.GetKeyDown(KeyCode.Keypad0)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[39]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 61) || Input.GetKeyDown(KeyCode.Keypad1)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[40]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 62) || Input.GetKeyDown(KeyCode.Keypad2)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[41]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 63) || Input.GetKeyDown(KeyCode.Keypad3)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[42]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 64) || Input.GetKeyDown(KeyCode.Keypad4)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[43]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 65) || Input.GetKeyDown(KeyCode.Keypad5)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[44]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 66) || Input.GetKeyDown(KeyCode.Keypad6)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[45]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 67) || Input.GetKeyDown(KeyCode.Keypad7)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[46]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 68) || Input.GetKeyDown(KeyCode.Keypad8)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[47]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69) || Input.GetKeyDown(KeyCode.Keypad9)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[48]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 70) || Input.GetKeyDown(KeyCode.T)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[49]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 71) || Input.GetKeyDown(KeyCode.E)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[50]);
        }
    }
    private void Octave_5()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 72) || Input.GetKeyDown(KeyCode.C)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[51]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 73)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[52]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 74)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[53]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 75)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[54]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 76)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[55]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 77)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[56]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 78)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[57]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 79)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[58]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 80)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[59]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 81)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[60]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 82)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[61]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 83)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[62]);
        }
    }
    private void Octave_6()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 84)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[63]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 85)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[64]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 86)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[65]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 87)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[66]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 88)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[67]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 89)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[68]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 90)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[69]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 91)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[70]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 92)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[71]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 93)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[72]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 94)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[73]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 95)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[74]);
        }
    }
    private void Octave_7()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 96)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[75]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 97)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[76]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 98)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[77]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 99)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[78]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 100)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[79]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 101)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[80]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 102)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[81]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 103)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[82]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 104)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[83]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 105)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[84]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 106)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[85]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 107)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[86]);
        }
    }
    private void Octave_8()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 108)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[87]);
        }
    }

    // For Octave Controller

    // Piano
    private void MidiPnoOctave_0()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[0]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 70)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[1]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 71)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[2]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 72)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[3]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 73)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[4]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 74)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[5]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 75)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[6]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 76)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[7]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 77)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[8]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 78)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[9]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 79)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[10]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 80)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[11]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 81)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[12]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 82)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[13]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 83)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[14]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 84)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[15]);
        }
    }
    private void MidiPnoOctave_1()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[3]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 61)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[4]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 62)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[5]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 63)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[6]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 64)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[7]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 65)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[8]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 66)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[9]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 67)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[10]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 68)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[11]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[12]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 70)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[13]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 71)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[14]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 72)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[15]);
        }
    }
    private void MidiPnoOctave_2()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[15]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 61)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[16]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 62)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[17]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 63)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[18]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 64)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[19]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 65)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[20]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 66)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[21]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 67)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[22]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 68)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[23]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[24]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 70)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[25]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 71)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[26]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 72)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[27]);
        }
    }
    private void MidiPnoOctave_3()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[27]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 61)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[28]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 62)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[29]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 63)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[30]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 64)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[31]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 65)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[32]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 66)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[33]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 67)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[34]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 68)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[35]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[36]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 70)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[37]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 71)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[38]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 72)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[39]);
        }
    }
    private void MidiPnoOctave_4()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60) || Input.GetKeyDown(KeyCode.Keypad0)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[39]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 61) || Input.GetKeyDown(KeyCode.Keypad1)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[40]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 62) || Input.GetKeyDown(KeyCode.Keypad2)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[41]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 63) || Input.GetKeyDown(KeyCode.Keypad3)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[42]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 64) || Input.GetKeyDown(KeyCode.Keypad4)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[43]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 65) || Input.GetKeyDown(KeyCode.Keypad5)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[44]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 66) || Input.GetKeyDown(KeyCode.Keypad6)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[45]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 67) || Input.GetKeyDown(KeyCode.Keypad7)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[46]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 68) || Input.GetKeyDown(KeyCode.Keypad8)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[47]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69) || Input.GetKeyDown(KeyCode.Keypad9)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[48]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 70) || Input.GetKeyDown(KeyCode.T)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[49]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 71) || Input.GetKeyDown(KeyCode.E)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[50]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 72)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[51]);
        }
    }
    private void MidiPnoOctave_5()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60) || Input.GetKeyDown(KeyCode.C)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[51]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 61)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[52]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 62)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[53]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 63)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[54]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 64)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[55]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 65)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[56]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 66)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[57]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 67)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[58]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 68)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[59]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[60]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 70)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[61]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 71)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[62]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 72)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[63]);
        }

    }
    private void MidiPnoOctave_6()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[63]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 61)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[64]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 62)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[65]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 63)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[66]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 64)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[67]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 65)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[68]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 66)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[69]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 67)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[70]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 68)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[71]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[72]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 70)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[73]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 71)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[74]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 72)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[75]);
        }
    }
    private void MidiPnoOctave_7()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[75]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 61)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[76]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 62)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[77]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 63)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[78]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 64)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[79]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 65)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[80]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 66)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[81]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 67)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[82]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 68)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[83]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[84]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 70)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[85]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 71)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[86]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 72)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[87]);
        }
    }
    private void MidiPnoOctave_8()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[87]);
        }
    }

    // Electric Piano
    private void EPnoOctave_4()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60) || Input.GetKeyDown(KeyCode.Keypad0)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[88]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 61) || Input.GetKeyDown(KeyCode.Keypad1)) //C#
        {
            AudioManager.Instance.PlaySFX(keyClips[89]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 62) || Input.GetKeyDown(KeyCode.Keypad2)) //D
        {
            AudioManager.Instance.PlaySFX(keyClips[90]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 63) || Input.GetKeyDown(KeyCode.Keypad3)) //D#
        {
            AudioManager.Instance.PlaySFX(keyClips[91]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 64) || Input.GetKeyDown(KeyCode.Keypad4)) //E
        {
            AudioManager.Instance.PlaySFX(keyClips[92]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 65) || Input.GetKeyDown(KeyCode.Keypad5)) //F
        {
            AudioManager.Instance.PlaySFX(keyClips[93]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 66) || Input.GetKeyDown(KeyCode.Keypad6)) //F#
        {
            AudioManager.Instance.PlaySFX(keyClips[94]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 67) || Input.GetKeyDown(KeyCode.Keypad7)) //G
        {
            AudioManager.Instance.PlaySFX(keyClips[95]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 68) || Input.GetKeyDown(KeyCode.Keypad8)) //G#
        {
            AudioManager.Instance.PlaySFX(keyClips[96]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69) || Input.GetKeyDown(KeyCode.Keypad9)) //A
        {
            AudioManager.Instance.PlaySFX(keyClips[97]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 70) || Input.GetKeyDown(KeyCode.T)) //A#
        {
            AudioManager.Instance.PlaySFX(keyClips[98]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 71) || Input.GetKeyDown(KeyCode.E)) //B
        {
            AudioManager.Instance.PlaySFX(keyClips[99]);
        }
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 72)) //C
        {
            AudioManager.Instance.PlaySFX(keyClips[100]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Full keyboard range, no octave or voice switch
        #region
        /*Octave_0();
        Octave_1();
        Octave_2();
        Octave_3();
        Octave_4();
        Octave_5();
        Octave_6();
        Octave_7();
        Octave_8();*/
        #endregion

        // Piano Octave Controller
        #region
        ChangeCounter();
        if (i == 0 && voice == 100)
        {
            MidiPnoOctave_0();
        }

        if (i == 1 && voice == 100)
        {
            MidiPnoOctave_1();
        }

        if (i == 2 && voice == 100)
        {
            MidiPnoOctave_2();
        }

        if (i == 3 && voice == 100)
        {
            MidiPnoOctave_3();
        }

        if (i == 4 && voice == 100)
        {
            MidiPnoOctave_4();
        }

        if (i == 5 && voice == 100)
        {
            MidiPnoOctave_5();
        }

        if (i == 6 && voice == 100)
        {
            MidiPnoOctave_6();
        }

        if (i == 7 && voice == 100)
        {
            MidiPnoOctave_7();
        }

        if (i == 8 && voice == 100)
        {
            MidiPnoOctave_8();
        }
        #endregion

        // Voice Changer
        ChangeVoice();

        // Electric Piano Octave Controller
        if (i == 4 && voice == 101)
        {
            EPnoOctave_4();
        }

    }
}
