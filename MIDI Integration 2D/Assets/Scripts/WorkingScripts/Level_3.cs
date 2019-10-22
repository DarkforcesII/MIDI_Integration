using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MidiJack;

public class Level_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        Scene currentScene = SceneManager.GetActiveScene();

        // Retreive name of scene
        string sceneName = currentScene.name;

        if (sceneName == "Intervals_Part_1")
        {
            OnCompletingInterval_Part_1();
        }
    }

    void OnCompletingInterval_Part_1()
    {
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 64))
        {
            if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60))
            {
                if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 69))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // This allows players to progress at their own pace
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60))
        {
            OnCompletingInterval_Part_1();
        }
    }
}