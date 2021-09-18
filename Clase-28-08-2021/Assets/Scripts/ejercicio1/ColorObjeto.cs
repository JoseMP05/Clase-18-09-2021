using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorObjeto : MonoBehaviour
{
    private Renderer colorCubo;
    public int idColor;


    // Start is called before the first frame update
    void Start()
    {
        colorCubo = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            idColor = Random.Range(0, 4);


        switch (idColor)
        {
            case 0:

                colorCubo.material.color = Color.red;

                break;
            case 1:

                colorCubo.material.color = Color.green;

                break;

            case 2:

                colorCubo.material.color = Color.blue;

                break;
            case 3:

                colorCubo.material.color = Color.yellow;

                break;

            default:

                colorCubo.material.color = Color.black;
                Debug.Log("El numuero asignado no es valido");

                break;
        }

        /*
        if (Input.GetKey(KeyCode.Q))
        {
            colorCubo.material.color = Color.red;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            colorCubo.material.color = Color.green;

        }else if (Input.GetKey(KeyCode.E))
        {
            colorCubo.material.color = Color.blue;
        }
        else
        {
            colorCubo.material.color = Color.yellow;
        }
        */

    }
       
}
