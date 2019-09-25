using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();

    }

    public void OnLevelChange()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
