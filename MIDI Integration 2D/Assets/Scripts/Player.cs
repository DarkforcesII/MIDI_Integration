using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;

    public string X;
    public string Y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
        }

        //midi controls
        if (Input.GetKey(KeyCode.Space))
        {

        }
    }
}
