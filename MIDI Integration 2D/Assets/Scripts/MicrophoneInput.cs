﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrophoneInput : MonoBehaviour
{

    private AudioSource audioSource;
    [SerializeField]private int audioSampleRate = 44100;

    // Start is called before the first frame update
    void Start()
    {
        // Get list of Microphone Devices
        foreach (var device in Microphone.devices)
        {
            Debug.Log("Name:" + device);
            //get components you'll need
		    audioSource = GetComponent<AudioSource> ();
        }
        //initialize input with default mic
        UpdateMicrophone();
    }

    void UpdateMicrophone()
    {
        //audioSource.Stop();
        //Start recording to audioclip from the mic
        audioSource.clip = Microphone.Start("Microphone (C-1U                     )", true, 10, audioSampleRate);
        audioSource.loop = true;
        // Mute the sound with an Audio Mixer group becuase we don't want the player to hear it
        Debug.Log(Microphone.IsRecording("Microphone (C-1U                     )").ToString());

        if (Microphone.IsRecording("Microphone (C-1U                     )"))
        { //check that the mic is recording, otherwise you'll get stuck in an infinite loop waiting for it to start
            while (!(Microphone.GetPosition("Microphone (C-1U                     )") > 0))
            {
            } // Wait until the recording has started. 

            Debug.Log("recording started with " + "Microphone (C-1U                     )");

            // Start playing the audio source
            audioSource.Play();
        }
        else
        {
            //microphone doesn't work for some reason

            Debug.Log("Realtek Mic (Realtek High Definition Audio)" + " doesn't work!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
