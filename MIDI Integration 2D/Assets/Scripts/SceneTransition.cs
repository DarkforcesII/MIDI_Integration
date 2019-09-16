using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneTransition : MonoBehaviour
{
    AudioSource Explosion;
    public AudioClip explosion;
    public float minPitch, maxPitch;

    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        StartCoroutine(Level_1());

        DontDestroyOnLoad(this);
        Explosion = GetComponent<AudioSource>();
    }

    IEnumerator Level_1()
    {
        yield return new WaitForSecondsRealtime(10f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Awake()
    {
        /*else if (scene.name == "Level2")
        {
            StartCoroutine(Level_2());

            IEnumerator Level_2()
            {
                yield return new WaitForSecondsRealtime(10f);
                SceneManager.LoadScene(sceneBuildIndex: 2);
            }
        }*/
    }

    public void PlayerExplosion()
    {
        Explosion.PlayOneShot(explosion);
        Explosion.pitch = Random.Range(minPitch, maxPitch);
    } 


    // Update is called once per frame
    void Update()
    {
        /*Scene scene = SceneManager.GetActiveScene();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerExplosion();
        }

        if (scene.name == "Level2") 
        {
            StartCoroutine(Level_2());

            IEnumerator Level_2()
            {
                yield return new WaitForSecondsRealtime(10f);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }*/
    }


}


