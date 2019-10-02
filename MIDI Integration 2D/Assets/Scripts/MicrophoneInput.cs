using System.Collections;
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
        }
    }

    void UpdateMicrophone()
    {
        audioSource.Stop();
        // Start recording to audio clip from the mic
        audioSource.clip = Microphone.Start("Microphone", true, 10, audioSampleRate);
        audioSource.loop = true;
        // Prevent feedback loop
        Debug.Log(Microphone.IsRecording("Microphone").ToString());

        if (Microphone.IsRecording("Microphone")) // checks that mic is actually recoridng
        {
            while (!(Microphone.GetPosition("Microphone") > 0))
                Debug.Log("recording started with" + "Microphone");

            // start playing audio source
            audioSource.Play();
        }
        else
        {
            // for whatever reason mic doesn't work
            Debug.Log("Realtek High Definition Audio" + "doesn't work!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
