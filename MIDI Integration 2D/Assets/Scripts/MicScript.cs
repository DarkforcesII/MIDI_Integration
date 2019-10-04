using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicScript : MonoBehaviour
{
    public static string[] devices;
    private AudioSource audioSource;
    AudioClip MicInput;

    // Start is called before the first frame update
    void Start()
    {
        // Get list of Microphone Devices
        foreach (var device in Microphone.devices)
        {
            Debug.Log("Name:" + device);
        }

        // Start recording with built in Microphone and play recorded audio right away
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = Microphone.Start("Realtek Mic (Realtek High Definition Audio)", true, 10, 48000);
        Microphone.IsRecording("Realtek Mic (Realtek High Definition Audio)");
        audioSource.Play();
        audioSource.loop = true;

        /*GetComponent<AudioSource>().PlayOneShot(MicInput);*/

    }

    void UpdateMicInput()
    {
        //micInput.Stop();
        // start recoridng
        //audioSource.clip = Microphone.Start(Microphone)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
