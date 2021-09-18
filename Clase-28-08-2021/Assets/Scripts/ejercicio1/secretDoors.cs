using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secretDoors : MonoBehaviour
{
    private int _numberTouches;
    public GameObject _puenteSecreto;
    public GameObject _secretLevel;
    private GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        _numberTouches = 3;
        _player = GameObject.FindGameObjectWithTag("Player");
      //_puenteSecreto = GameObject.FindGameObjectWithTag("secretlevel");
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _numberTouches--;
            Debug.Log(_numberTouches);
            if(_numberTouches == 0)
            {
                Destroy(gameObject);
                _puenteSecreto.SetActive(true);
                _secretLevel.SetActive(true);
            }
        }
    }
}
