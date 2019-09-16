using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class NewFadeScript : MonoBehaviour
{
    public static NewFadeScript thisScript;
    public bool LowpassOn;
    public float LPPercent;
    public float minHz = 280;
    public float maxHz = 22000;
    public AudioMixer Lowpass;
    public float FadeSpeed = 1;

    private void Awake()
    {
        thisScript = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LowpassOn)
        {
            if (LPPercent < 1)
                LPPercent += Time.fixedUnscaledDeltaTime*FadeSpeed;
            else
            {
                LPPercent = 1;
            }
        }
        else
        {
            if (LPPercent > 0)
                LPPercent -= Time.fixedUnscaledDeltaTime*FadeSpeed;
            else
            {
                LPPercent = 0;
            }
        }
        Lowpass.SetFloat("HzLvl", Mathf.Lerp(maxHz, minHz, LPPercent));
    }
}
