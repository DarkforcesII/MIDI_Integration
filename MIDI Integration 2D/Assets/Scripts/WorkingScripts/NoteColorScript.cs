using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;
using UnityEngine.SceneManagement;

public class NoteColorScript : MonoBehaviour
{

    private Renderer render;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
        /*audioClip1 = Resources.Load<AudioClip>("Audio/C#_4");*/ // save for later
    }

    private void Octave_4()
    {
        if (gameObject.CompareTag("C"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60) || Input.GetKeyDown(KeyCode.Keypad0)) //C
            {
                render.material.SetColor("_Color", Color.red);
            }
            else if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 60) || Input.GetKeyUp(KeyCode.Keypad0))
            {
                render.material.SetColor("_Color", Color.white);
            }
        }
        if (gameObject.CompareTag("C_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 61) || Input.GetKeyDown(KeyCode.Keypad1)) //C#
            {
                render.material.SetColor("_Color", Color.red);
            }
            else if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 61) || Input.GetKeyUp(KeyCode.Keypad1))
            {
                render.material.SetColor("_Color", Color.black);
            }
        }
        if (gameObject.CompareTag("D"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 62) || Input.GetKeyDown(KeyCode.Keypad2)) //D
            {
                render.material.SetColor("_Color", Color.red);
            }
            else if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 62) || Input.GetKeyUp(KeyCode.Keypad2))
            {
                render.material.SetColor("_Color", Color.white);
            }
        }
        if (gameObject.CompareTag("D_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 63) || Input.GetKeyDown(KeyCode.Keypad3)) //D#
            {
                render.material.SetColor("_Color", Color.red);
            }
            else if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 63) || Input.GetKeyUp(KeyCode.Keypad3))
            {
                render.material.SetColor("_Color", Color.black);
            }
        }
        if (gameObject.CompareTag("E"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 64) || Input.GetKeyDown(KeyCode.Keypad4)) //E
            {
                render.material.SetColor("_Color", Color.red);
            }
            else if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 64) || Input.GetKeyUp(KeyCode.Keypad4))
            {
                render.material.SetColor("_Color", Color.white);
            }
        }
        if (gameObject.CompareTag("F"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 65) || Input.GetKeyDown(KeyCode.Keypad5)) //F
            {
                render.material.SetColor("_Color", Color.red);
            }
            else if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 65) || Input.GetKeyUp(KeyCode.Keypad5))
            {
                render.material.SetColor("_Color", Color.white);
            }
        }
        if (gameObject.CompareTag("F_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 66) || Input.GetKeyDown(KeyCode.Keypad6)) //F#
            {
                render.material.SetColor("_Color", Color.red);
            }
            else if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 66) || Input.GetKeyUp(KeyCode.Keypad6))
            {
                render.material.SetColor("_Color", Color.black);
            }
        }
        if (gameObject.CompareTag("G"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 67) || Input.GetKeyDown(KeyCode.Keypad7)) //G
            {
                render.material.SetColor("_Color", Color.red);
            }
            else if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 67) || Input.GetKeyUp(KeyCode.Keypad7))
            {
                render.material.SetColor("_Color", Color.white);
            }
        }
        if (gameObject.CompareTag("G_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 68) || Input.GetKeyDown(KeyCode.Keypad8)) //G#
            {
                render.material.SetColor("_Color", Color.red);
            }
            else if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 68) || Input.GetKeyUp(KeyCode.Keypad8))
            {
                render.material.SetColor("_Color", Color.black);
            }
        }
        if (gameObject.CompareTag("A"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69) || Input.GetKeyDown(KeyCode.Keypad9)) //A
            {
                render.material.SetColor("_Color", Color.red);
            }
            else if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 69) || Input.GetKeyUp(KeyCode.Keypad9))
            {
                render.material.SetColor("_Color", Color.white);
            }
        }
        if (gameObject.CompareTag("A_Sharp"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 70) || Input.GetKeyDown(KeyCode.T)) //A#
            {
                render.material.SetColor("_Color", Color.red);
            }
            else if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 70) || Input.GetKeyUp(KeyCode.T))
            {
                render.material.SetColor("_Color", Color.black);
            }
        }
        if (gameObject.CompareTag("B"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 71) || Input.GetKeyDown(KeyCode.E)) //B
            {
                render.material.SetColor("_Color", Color.red);
            }
            else if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 71) || Input.GetKeyUp(KeyCode.E))
            {
                render.material.SetColor("_Color", Color.white);
            }
        }
    }
    private void Octave_5()
    {
        if (gameObject.CompareTag("C"))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 72) || Input.GetKeyDown(KeyCode.C)) //C
            {
                render.material.SetColor("_Color", Color.red);
            }
            else if (MidiDriver.Instance.GetKeyUp(MidiChannel.All, 72) || Input.GetKeyUp(KeyCode.C))
            {
                render.material.SetColor("_Color", Color.white);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Octave_4();
        Octave_5();
    }
}
