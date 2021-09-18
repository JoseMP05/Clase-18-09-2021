using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puente : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject, 0.3f);
        }
    }
}
