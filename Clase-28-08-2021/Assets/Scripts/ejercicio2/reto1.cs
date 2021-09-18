using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reto1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 31; i++)
        {
            if(i <= 10)
            {
                Debug.Log(i);
            }
            else if(i <= 20) {
                if(i % 2 == 0)
                {
                    Debug.Log(i);
                }
            }

            else
            {
                if (i % 2 != 0)
                {
                    Debug.Log(i);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
