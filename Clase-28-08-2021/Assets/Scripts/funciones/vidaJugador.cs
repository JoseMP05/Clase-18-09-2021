using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaJugador : MonoBehaviour
{
    public int health = 100;
    public bool isDead;
    public int dead;
    // Start is called before the first frame update
    void Start()
    {
        dead = 0;
    }

    // Update is called once per frame
    void Update()
    {
        LoseLife();
    }

    public void  LoseLife()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(Random.Range(5,20));
            Debug.Log(health);
        }

    }

    public void Damage(int damageIncrement)
    {
        health -= damageIncrement;
        if (health <= dead)
        {
            isDead = true;
            health= dead;
            Debug.Log("Player dead: " + isDead);
        }
    }
}
