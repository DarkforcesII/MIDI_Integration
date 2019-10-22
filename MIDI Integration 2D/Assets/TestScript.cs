using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int totalNums = 8;
        int numbers = 0;
        for (int i = 1; i <= totalNums; i++)
        {
            if (numbers <= i * 2)
            {
                numbers += i * 4;
            }
            print("please work" + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
