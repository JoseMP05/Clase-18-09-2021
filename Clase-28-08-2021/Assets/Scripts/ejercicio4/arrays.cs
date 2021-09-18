using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    public string[] arreglo1 = new string[3] {"jose" , "miguel", "oscar"};
    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < arreglo1.Length; i++)
        //{
        //    Debug.Log(arreglo1[i]);
        //}
        for (int i = 0; i < arreglo1.Length; i++)
        {
            if (arreglo1[i] == "miguel")
            {
                Debug.Log(arreglo1[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
