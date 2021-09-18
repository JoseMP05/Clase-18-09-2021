using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levels : MonoBehaviour
{
    public Renderer colorFloor;
    // Start is called before the first frame update


    private void OnTriggerStay (Collider other)
    {
        if (other.tag == "Player"){
            colorFloor.material.color = Color.blue;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            colorFloor.material.color = Color.red;
        }
    }
    // Update is called once per frame
}
