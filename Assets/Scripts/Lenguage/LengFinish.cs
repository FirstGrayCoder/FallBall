using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LengFinish : MonoBehaviour
{
    public static int _checkLeng;
    [SerializeField] private Text _FirstUKR;
    [SerializeField] private Text _FirstEng;
    [SerializeField] private Text _SecondUKR;
    [SerializeField] private Text _SecondEng;

    // Start is called before the first frame update
    void Awake()
    {
        //  _checkLeng = PlayerPrefs.GetInt("_checkLeng");
        //  PlayerPrefs.SetInt("_checkLeng", _checkLeng);

        if(Application.systemLanguage == SystemLanguage.Russian || Application.systemLanguage == SystemLanguage.Ukrainian) 
        {
            //_checkLeng = 0;
            _FirstUKR.gameObject.SetActive(true);
            _FirstEng.gameObject.SetActive(false);
            _SecondUKR.gameObject.SetActive(true);
            _SecondEng.gameObject.SetActive(false);
        }
        else if(Application.systemLanguage == SystemLanguage.English ) 
        {
           // _checkLeng = 1;
            _FirstUKR.gameObject.SetActive(false);
            _FirstEng.gameObject.SetActive(true);
            _SecondUKR.gameObject.SetActive(false);
            _SecondEng.gameObject.SetActive(true);
        }
        else 
        {
            //_checkLeng = 1;
            _FirstUKR.gameObject.SetActive(false);
            _FirstEng.gameObject.SetActive(true);
            _SecondUKR.gameObject.SetActive(false);
            _SecondEng.gameObject.SetActive(true);
        }
    }
}
