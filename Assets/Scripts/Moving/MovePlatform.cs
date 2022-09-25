using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    //[SerializeField] private GameObject _platform;
    //[SerializeField] private Vector3 _currentPosition;
    private bool _movingRigtOrUp = true;
    [SerializeField] private float _speed;
    public GameObject pointA;
    public GameObject pointB;
    [SerializeField] private float _distance;

     void FixedUpdate()
    {
        if(Vector2.Distance(transform.position, pointA.transform.position) > _distance && _movingRigtOrUp == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, pointA.transform.position, _speed);
        }
        else 
        {
            _movingRigtOrUp = false;
            transform.position = Vector2.MoveTowards(transform.position, pointB.transform.position, _speed);
                if(Vector2.Distance(transform.position, pointB.transform.position) > _distance && _movingRigtOrUp == false)
                {
                    transform.position = Vector2.MoveTowards(transform.position, pointB.transform.position, _speed);
                }else
                    _movingRigtOrUp = true;
                    transform.position = Vector2.MoveTowards(transform.position, pointA.transform.position, _speed);
        }
    }
}
