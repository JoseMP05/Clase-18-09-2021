using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _movimientoHorizontal;
    private float _movimientoVertical;
    public float speed = 1f;

    public Renderer colorFloor;

    public GameObject enemy;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RBMovimiento();
    }

    public void RBMovimiento()
    {
        _movimientoHorizontal = Input.GetAxis("Horizontal");
        _movimientoVertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(_movimientoHorizontal, 0, _movimientoVertical) * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Floor"))
        {
            colorFloor.material.color = Color.blue;
        }

        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(this.gameObject);
            
        }

        //if (collision.gameObject.CompareTag("Base"))
        //{
        //    enemy.SetActive(false);
            
        //}

        //if (collision.gameObject.CompareTag("Base2"))
        //{
        //    enemy.SetActive(true);
        //}

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            colorFloor.material.color = Color.red;
        }
    }
 








}
