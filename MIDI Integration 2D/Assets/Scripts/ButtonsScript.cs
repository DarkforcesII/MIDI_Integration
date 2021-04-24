using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * script for controlling ui functionality for mobile
 */

public class ButtonsScript : MonoBehaviour
{
    public Button c, cSharp, d, eFlat, e, f, fSharp, g, gSharp, a, bFlat, b;
    public GeneralPianoScript pianoScript;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // methods for playing key for each button
    // switch statement corresponds to octave currently active
    #region
    public void playB()
    {

        switch (pianoScript.i)
        {
            case 0:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[2]);
                break;
            case 1:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[14]);
                break;
            case 2:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[26]);
                break;
            case 3:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[38]);
                break;
            case 4:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[50]);
                break;
            case 5:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[62]);
                break;
            case 6:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[74]);
                break;
            case 7:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[86]);
                break;
        }
    }

    public void playbFlat()
    {
        switch (pianoScript.i)
        {
            case 0:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[1]);
                break;
            case 1:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[13]);
                break;
            case 2:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[25]);
                break;
            case 3:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[37]);
                break;
            case 4:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[49]);
                break;
            case 5:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[61]);
                break;
            case 6:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[73]);
                break;
            case 7:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[85]);
                break;
        }
    }

    public void playA()
    {
        switch (pianoScript.i)
        {
            case 0:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[0]);
                break;
            case 1:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[12]);
                break;
            case 2:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[24]);
                break;
            case 3:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[36]);
                break;
            case 4:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[48]);
                break;
            case 5:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[60]);
                break;
            case 6:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[72]);
                break;
            case 7:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[84]);
                break;
        }
    }

    public void playgSharp()
    {
        switch (pianoScript.i)
        {
            case 1:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[11]);
                break;
            case 2:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[23]);
                break;
            case 3:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[35]);
                break;
            case 4:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[47]);
                break;
            case 5:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[59]);
                break;
            case 6:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[71]);
                break;
            case 7:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[83]);
                break;
        }
    }

    public void playG()
    {
        switch (pianoScript.i)
        {
            case 1:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[10]);
                break;
            case 2:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[22]);
                break;
            case 3:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[34]);
                break;
            case 4:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[46]);
                break;
            case 5:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[58]);
                break;
            case 6:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[70]);
                break;
            case 7:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[82]);
                break;
        }
    }

    public void playfSharp()
    {
        switch (pianoScript.i)
        {
            case 1:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[9]);
                break;
            case 2:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[21]);
                break;
            case 3:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[33]);
                break;
            case 4:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[45]);
                break;
            case 5:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[57]);
                break;
            case 6:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[69]);
                break;
            case 7:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[81]);
                break;
        }
    }

    public void playF()
    {
        switch (pianoScript.i)
        {
            case 1:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[8]);
                break;
            case 2:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[20]);
                break;
            case 3:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[32]);
                break;
            case 4:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[44]);
                break;
            case 5:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[56]);
                break;
            case 6:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[68]);
                break;
            case 7:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[80]);
                break;
        }
    }

    public void playE()
    {
        switch (pianoScript.i)
        {
            case 1:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[7]);
                break;
            case 2:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[19]);
                break;
            case 3:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[31]);
                break;
            case 4:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[43]);
                break;
            case 5:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[55]);
                break;
            case 6:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[67]);
                break;
            case 7:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[79]);
                break;
        }
    }

    public void playeFlat()
    {
        switch (pianoScript.i)
        {
            case 1:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[6]);
                break;
            case 2:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[18]);
                break;
            case 3:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[30]);
                break;
            case 4:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[42]);
                break;
            case 5:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[54]);
                break;
            case 6:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[66]);
                break;
            case 7:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[78]);
                break;
        }
    }

    public void playD()
    {
        switch (pianoScript.i)
        {
            case 1:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[5]);
                break;
            case 2:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[17]);
                break;
            case 3:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[29]);
                break;
            case 4:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[41]);
                break;
            case 5:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[53]);
                break;
            case 6:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[65]);
                break;
            case 7:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[77]);
                break;
        }
    }

    public void playcSharp()
    {
        switch (pianoScript.i)
        {
            case 1:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[4]);
                break;
            case 2:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[16]);
                break;
            case 3:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[28]);
                break;
            case 4:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[40]);
                break;
            case 5:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[52]);
                break;
            case 6:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[64]);
                break;
            case 7:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[76]);
                break;
        }
    }

    public void playC()
    {
        switch (pianoScript.i)
        {
            case 1:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[3]);
                break;
            case 2:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[15]);
                break;
            case 3:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[27]);
                break;
            case 4:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[39]);
                break;
            case 5:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[51]);
                break;
            case 6:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[63]);
                break;
            case 7:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[75]);
                break;
            case 8:
                AudioManager.Instance.PlaySFX(pianoScript.keyClips[87]);
                break;
        }
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
        
    }
}
