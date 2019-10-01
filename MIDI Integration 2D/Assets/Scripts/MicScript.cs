using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicScript : MonoBehaviour
{
    public static string[] devices;

    // Start is called before the first frame update
    void Start()
    {
        // Get list of Microphone Devices
        foreach (var device in Microphone.devices)
        {
            Debug.Log("Name:" + device);
        }

        // Start recording with built in Microphone and play recorded audio right away
        AudioSource micInput = GetComponent<AudioSource>();
        micInput.clip = Microphone.Start("Realtek High Definition Audio", true, 10, 44100);
        /*micInput.Play();*/
        /*GetComponent<AudioSource>().PlayOneShot(AudioClip);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
