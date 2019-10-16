using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;
using MidiJack;

public class LevelTransition : MonoBehaviour
{
    private AudioClip C;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        C = Resources.Load<AudioClip>("Audio/C_4");

        // Retreive name of scene
        string sceneName = currentScene.name;

        if (sceneName == "Prototype") 
        {
            StartCoroutine(Level_2());
        }

        if (sceneName == "Level_2")
        {
            StartCoroutine(EarTraining());
        }

    }

    public void ToPrototypeLevel()
    {
        StartCoroutine(PrototypeLevel());
    }

    IEnumerator PrototypeLevel()
    {
        yield return new WaitForSecondsRealtime(3.5f); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /*public void ToLevel_2()
    {
        StartCoroutine(Level_2());
    }*/

    IEnumerator Level_2()
    {
        yield return new WaitForSecondsRealtime(10);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator EarTraining()
    {
        yield return new WaitForSecondsRealtime(10);
        AudioManager.Instance.PlaySFX(C);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
        print("I Quit");
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnApplicationQuit();
        }
      if (Input.GetKeyDown(KeyCode.R))
        {
            AudioManager.Instance.PlaySFX(C);
        }

      // This allows players to progress at their own pace
      if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
