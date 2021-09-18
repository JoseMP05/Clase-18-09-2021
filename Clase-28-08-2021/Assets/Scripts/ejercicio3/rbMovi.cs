using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbMovi : MonoBehaviour
{
    private float _movimientoHorizontal;
    private float _movimientoVertical;
    public float speed = 1f;


    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _movimientoHorizontal = Input.GetAxis("Horizontal");
        _movimientoVertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(_movimientoHorizontal, 0, _movimientoVertical) * speed);
    }
}
