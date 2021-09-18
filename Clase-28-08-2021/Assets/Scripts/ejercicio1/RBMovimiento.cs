using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBMovimiento : MonoBehaviour
{
    private float _movimientoHorizontal;
    private float _movimientoVertical;
    public float speed = 10f;
    //private float _speedmax = 0f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //_speedmax = Random.Range(60f, 120f);
        //StartCoroutine(speedPlayer());

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _movimientoHorizontal = Input.GetAxis("Horizontal");
        _movimientoVertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(_movimientoHorizontal, 0, _movimientoVertical) * speed);
    }

    /* Corrotina para aumentar la velocidad del player 5f cada segundo
    IEnumerator speedPlayer()
    {
        for (int i = 0; i < _speedmax; i= i+5)
        {
            Debug.Log(speed);
            speed = speed + 5;
            if(speed > _speedmax)
            {
                Debug.Log(_speedmax);
                rb.AddForce(new Vector3((-100*_movimientoHorizontal), 0, (-100*_movimientoVertical)));
            }
            yield return new WaitForSeconds(1.0f);
        }
    }
    */
}
