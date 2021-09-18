using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioColor : MonoBehaviour
{
    public Renderer color;
    //private GameObject _player;
    // cambiar el color con el tag Player al oprimir la tecla espacio usando metodos
    // Start is called before the first frame update
    void Start()
    {
        //_player = GameObject.FindGameObjectWithTag("Player");
        color.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ColorPlayer();
        }
    }

    private void ColorPlayer()
    {
        color.material.color = Color.red;
    }
}
