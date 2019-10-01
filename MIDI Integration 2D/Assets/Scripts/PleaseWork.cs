using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;
public class PleaseWork : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        MidiDriver.Instance.GetKey(MidiChannel.All,5);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 129; i++)
        {


            if (MidiDriver.Instance.GetKey(MidiChannel.All, i) > 0)
            {
                print("please work"+ i);

            }
        }
    }

}
