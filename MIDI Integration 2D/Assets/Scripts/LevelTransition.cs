using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class LevelTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

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
        yield return new WaitForSecondsRealtime(20); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator EarTraining()
    {
        yield return new WaitForSecondsRealtime(20);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
    }
}
