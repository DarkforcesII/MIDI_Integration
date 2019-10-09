using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class AudioScriptsTest : MonoBehaviour
{
    [SerializeField] private AudioClip C;
    [SerializeField] private AudioClip E;
    [SerializeField] private AudioClip G;
    AudioSource audioManagerTest;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60))
        {
            AudioManager.Instance.PlaySFX(C, 1);
        }
    }
}
