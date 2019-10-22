using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;
using MidiJack;

public class LevelTransition : MonoBehaviour
{
    private AudioClip C;
    private AudioClip E;
    private AudioClip A;
    // Start is called before the first frame update
    void Start()
    {
        C = Resources.Load<AudioClip>("Audio/C_4");
        E = Resources.Load<AudioClip>("Audio/E_4");
        A = Resources.Load<AudioClip>("Audio/A_4");

        Scene currentScene = SceneManager.GetActiveScene();

        // Retreive name of scene
        string sceneName = currentScene.name;

        if (sceneName == "Prototype") 
        {
            StartCoroutine(Level_2());
        }

        if (sceneName == "Level_2")
        {
            StartCoroutine(EarTrainingStart());
        }

        if (sceneName == "Intervals_Part_1")
        {
            StartCoroutine(Intervals_Part_1());
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

    IEnumerator Level_2()
    {
        yield return new WaitForSecondsRealtime(10);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator EarTrainingStart()
    {
        yield return new WaitForSecondsRealtime(10);
        AudioManager.Instance.PlaySFX(C);
    }

    IEnumerator Intervals_Part_1()
    {
        yield return new WaitForSecondsRealtime(10);
        AudioManager.Instance.PlaySFX(C);
        yield return new WaitForSecondsRealtime(4);
        AudioManager.Instance.PlaySFX(E);
        yield return new WaitForSecondsRealtime(4);
        AudioManager.Instance.PlaySFX(C);
        yield return new WaitForSecondsRealtime(4);
        AudioManager.Instance.PlaySFX(A);
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
        if (Input.GetKeyDown(KeyCode.I))
        {
            StartCoroutine(Intervals_Part_1());
        }
    }
}
