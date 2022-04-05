using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemyMovement : MonoBehaviour
{

    [SerializeField]
    private float moveY = 5;

    [SerializeField]
    private float speed = 1;
    private float _direction = 1;

    private Vector3 _startPosition;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.y - _startPosition.y > moveY)
        {
            _direction = -1;
        }
        if (transform.localPosition.y - _startPosition.y < -moveY)
        {
            _direction = 1;
        }

        transform.Translate(Vector3.up * _direction * Time.deltaTime * speed);

    }
}