using UnityEngine;
using UnityEngine.UI;

public class LengFirstLevel : MonoBehaviour
{
    [SerializeField] private Text _TextUKR;
    [SerializeField] private Text _TextEng;
    [SerializeField] private Text _SecondTextUKR;
    [SerializeField] private Text _SecondTextEng;
    [SerializeField] private Text _ThirdTextUKR;
    [SerializeField] private Text _ThirdTextEng;

    // Start is called before the first frame update
    void Awake()
    {
        //  _checkLeng = PlayerPrefs.GetInt("_checkLeng");
        //  PlayerPrefs.SetInt("_checkLeng", _checkLeng);

        if(Application.systemLanguage == SystemLanguage.Russian || Application.systemLanguage == SystemLanguage.Ukrainian) 
        {
            //_checkLeng = 0;
            _TextUKR.gameObject.SetActive(true);
            _TextEng.gameObject.SetActive(false);
            _SecondTextUKR.gameObject.SetActive(true);
            _SecondTextEng.gameObject.SetActive(false);
            _ThirdTextUKR.gameObject.SetActive(true);
            _ThirdTextEng.gameObject.SetActive(false);
        }
        else if(Application.systemLanguage == SystemLanguage.English ) 
        {
           // _checkLeng = 1;
            _TextUKR.gameObject.SetActive(false);
            _TextEng.gameObject.SetActive(true);
            _SecondTextUKR.gameObject.SetActive(false);
            _SecondTextEng.gameObject.SetActive(true);
            _ThirdTextUKR.gameObject.SetActive(false);
            _ThirdTextEng.gameObject.SetActive(true);
        }
        else 
        {
            //_checkLeng = 1;
            _TextUKR.gameObject.SetActive(false);
            _TextEng.gameObject.SetActive(true);
            _SecondTextUKR.gameObject.SetActive(false);
            _SecondTextEng.gameObject.SetActive(true);
            _ThirdTextUKR.gameObject.SetActive(false);
            _ThirdTextEng.gameObject.SetActive(true);
        }
    }
}
