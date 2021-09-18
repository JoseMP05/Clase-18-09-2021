using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 101; i++)
        {
            if(i % 2 == 0)
            {
                Debug.Log(i);
            }
            else
            {
                Debug.Log("impar" + i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
