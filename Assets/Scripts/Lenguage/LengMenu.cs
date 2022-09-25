using UnityEngine;
using UnityEngine.UI;

public class LengMenu : MonoBehaviour
{
    [SerializeField] private Text _PlayUKR;
    [SerializeField] private Text _PlayEng;
    [SerializeField] private Text _ExitUKR;
    [SerializeField] private Text _ExitEng;

    // Start is called before the first frame update
    void Awake()
    {
        //  _checkLeng = PlayerPrefs.GetInt("_checkLeng");
        //  PlayerPrefs.SetInt("_checkLeng", _checkLeng);

        if(Application.systemLanguage == SystemLanguage.Russian || Application.systemLanguage == SystemLanguage.Ukrainian) 
        {
            //_checkLeng = 0;
            _PlayUKR.gameObject.SetActive(true);
            _PlayEng.gameObject.SetActive(false);
            _ExitUKR.gameObject.SetActive(true);
            _ExitEng.gameObject.SetActive(false);
        }
        else if(Application.systemLanguage == SystemLanguage.English ) 
        {
           // _checkLeng = 1;
            _PlayUKR.gameObject.SetActive(false);
            _PlayEng.gameObject.SetActive(true);
            _ExitUKR.gameObject.SetActive(false);
            _ExitEng.gameObject.SetActive(true);
        }
        else 
        {
            //_checkLeng = 1;
            _PlayUKR.gameObject.SetActive(false);
            _PlayEng.gameObject.SetActive(true);
            _ExitUKR.gameObject.SetActive(false);
            _ExitEng.gameObject.SetActive(true);
        }
    }
}
