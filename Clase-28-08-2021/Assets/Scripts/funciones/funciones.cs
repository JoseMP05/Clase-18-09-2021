using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funciones : MonoBehaviour
{
    public int health = 100;
    protected GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        int total = Suma(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(10);
            Debug.Log(health);
        }
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health == 0)
        {
            Destroy(_player);
        }
    }
    //sintaxis de una funcion
    private int Suma (int numero1, int numero2)
    {
        int resultado = numero1 + numero2;
        return resultado;
    }
}
