using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScripts : MonoBehaviour
{
    public int lifes;
    private Renderer _colorPlayer;
    private int _score = 0;
    // Start is called before the first frame update
    void Start()
    {
        _colorPlayer = GetComponent<Renderer>();
        lifes = 3;       
    }

    // Update is called once per frame
    void Update()
    {
        LifesPlayer();
    }

    public void LifesPlayer()
    {
        if (lifes >= 3)
        {
            _colorPlayer.material.color = Color.green;
        }

        else if (lifes == 2)
        {
            _colorPlayer.material.color = Color.yellow;
        }

        else if (lifes == 1)
        {
            _colorPlayer.material.color = Color.red;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    //funcion para bajarle vidas al player cada que colisiones contra un enemigo. Al tener cero vidas se destruira
    void OnCollisionEnter(Collision  collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            lifes--;
            Debug.Log("lifes: " + lifes);
            if(lifes == 0)
            {
            Destroy(gameObject);
                Debug.Log("Player is dead");
            }
        }

        if (collision.gameObject.CompareTag("door"))
        {
            lifes--;
            Debug.Log("lifes: " + lifes);
            if (lifes == 0)
            {
                Destroy(gameObject);
                Debug.Log("Player is dead");
            }
        }
    }


    //funcion para sumas punto al recoger monedas y ganar una vida cada 10 puntos y recoger vidas en el juego
    private void OnTriggerEnter(Collider other)
    {   
        //coins
        if(other.tag == "coin")
        {
            _score++;
            Debug.Log("_score: " +_score);
            if(_score == 10)
            {
                _score = 0;
                lifes += 1;
            }
        }
        //vidas
        if (other.tag == "life")
        {
            lifes += 1;
        }
    }
}
