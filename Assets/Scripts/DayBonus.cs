using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DayBonus : MonoBehaviour
{
    [SerializeField] private float _bonusButtonTimer;
    [SerializeField] private Text _timerText;

    // Start is called before the first frame update
    void Start()
    {
        _bonusButtonTimer = 10;
        _timerText.GetComponent<Animator>().enabled = false; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(10+33%5*7/3%4+3);
        if (_bonusButtonTimer > 0)
        {
            _bonusButtonTimer -= Time.deltaTime;
            if (_bonusButtonTimer <= 3)
            {
                _timerText.color = Color.red;
                _timerText.GetComponent<Animator>().enabled = true;
            }
            //_timerText.GetComponent<Animator>().enabled = false;
        }
        else _timerText.GetComponent<Animator>().enabled = false;
        _timerText.text = Mathf.Round(_bonusButtonTimer).ToString();

    }

}
