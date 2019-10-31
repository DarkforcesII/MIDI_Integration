using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MidiJack;

public class Level_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        Scene currentScene = SceneManager.GetActiveScene();

        // Retreive name of scene
        string sceneName = currentScene.name;

        if (sceneName == "Level_2")
        {
            StartCoroutine(EarTrainingExercise());
        }
    }

    IEnumerator EarTrainingExercise()
    {
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        // This allows players to progress at their own pace
        if (MidiDriver.Instance.GetKeyDown(MidiChannel.All, 60) || (Input.GetKeyDown(KeyCode.Keypad0)))
        {
            Start();
        }
    }
}
