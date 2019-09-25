using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioStems : MonoBehaviour
{

    AudioSource mainAudio;
    public AudioClip bassLine;
    public AudioClip chords;
    public AudioClip MenuSelect;
    public AudioClip melody;
    public AudioClip strings;
    public AudioClip ModeSelect;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Chords());
        StartCoroutine(Melody());
        StartCoroutine(BassLine());
        StartCoroutine(Strings());
    }

    public void OnMouseClick()
    {
        GetComponent<AudioSource>().PlayOneShot(MenuSelect);
    }

    public void OnMouseEnter()
    {
        GetComponent<AudioSource>().PlayOneShot(MenuSelect);
    }

    public void OnModeSelect()
    {
        GetComponent<AudioSource>().PlayOneShot(ModeSelect);
    }

    IEnumerator Chords()
    {
        while (true)
        {
            GetComponent<AudioSource>().PlayOneShot(chords);
            yield return new WaitForSecondsRealtime(27.428f);
        }
    }

    IEnumerator BassLine()
    {
        if (Random.value > 0.2)
        {
            while (true)
            {
                GetComponent<AudioSource>().PlayOneShot(bassLine);
                yield return new WaitForSecondsRealtime(27.428f);
            }
        }
    }

    IEnumerator Melody()
    {
        while (true)
        {
            if(Random.value > 0.5)
            {
                GetComponent<AudioSource>().PlayOneShot(melody);
            }
            yield return new WaitForSecondsRealtime(27.428f);
        }
    }

    IEnumerator Strings()
    {
        if (Random.value > 0.7)
        {
            GetComponent<AudioSource>().PlayOneShot(strings);
        }
        yield return new WaitForSecondsRealtime(27.428f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
