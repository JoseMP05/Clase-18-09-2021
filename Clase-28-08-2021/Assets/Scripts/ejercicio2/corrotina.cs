using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corrotina : MonoBehaviour
{
    public int manzanas;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AgregarManzanas());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AgregarManzanas()
    {
        for (int i = 1; i < 101; i++)
        {
            manzanas++;
            Debug.Log("# de manzanas" + manzanas);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
