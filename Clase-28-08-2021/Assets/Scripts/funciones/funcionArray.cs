using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcionArray : MonoBehaviour
{
    public GameObject[] players;
    // Start is called before the first frame update
    void Start()
    {
        players = GetAllPlayers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject[] GetAllPlayers()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");
        foreach(var item in allPlayers)
        {
            item.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }

        //con un for
        for(int i = 0; i > allPlayers.Length; i++)
        {
            allPlayers[i].gameObject.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        return allPlayers;
    }
}
