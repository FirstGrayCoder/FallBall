using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMenu : MonoBehaviour
{
    [SerializeField] private GameObject GO;
    [SerializeField] private GameObject _firstPlatform;
    [SerializeField] private GameObject _movePlat;
    [SerializeField] private Vector2 _startPosition;
    [SerializeField] private float _speed;
    public GameObject pointA;
    public GameObject pointB;
    public float distance;
    private bool isTrig;
    private bool onPointA;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = GO.transform.position;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Respawn")
        {
            isTrig = true;
            onPointA = true;
            _firstPlatform.GetComponent<Collider2D>().enabled = false;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (isTrig && onPointA == true && Vector2.Distance(_movePlat.transform.position, pointA.transform.position) > distance)
        {
            //Debug.Log(" Fixed Update is Trig " + isTrig);
            _movePlat.transform.position = Vector2.MoveTowards(_movePlat.transform.position, pointA.transform.position, _speed);
        }
        else
        {
            onPointA = false;
            _firstPlatform.GetComponent<Collider2D>().enabled = true;
            _movePlat.transform.position = Vector2.MoveTowards(_movePlat.transform.position, pointB.transform.position, _speed);
            if (Vector2.Distance(_movePlat.transform.position, pointB.transform.position) > distance && onPointA == false)
            {
            _movePlat.transform.position = Vector2.MoveTowards(_movePlat.transform.position, pointB.transform.position, _speed);
            }
            else 
            {
                onPointA = true;
                isTrig = false;
            }
            

        }
        //     if (Vector2.Distance(_movePlat.transform.position, pointA.transform.position) <= distance)
        //      onPointA = false;
        // if(onPointA == false)
        // {
        //     _movePlat.transform.position = Vector2.MoveTowards(_movePlat.transform.position, pointB.transform.position, _speed);
        //     if(Vector2.Distance(_movePlat.transform.position, pointA.transform.position) > distance)
        //     {
        //         _movePlat.transform.position = Vector2.MoveTowards(_movePlat.transform.position, pointB.transform.position, _speed);
        //     }
        // }

        

    }
}
