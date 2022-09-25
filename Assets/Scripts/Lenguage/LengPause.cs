using UnityEngine;
using UnityEngine.UI;

public class LengPause : MonoBehaviour
{
    [SerializeField] private Text _ContinueUKR;
    [SerializeField] private Text _ContinueEng;
    [SerializeField] private Text _ExitUKR;
    [SerializeField] private Text _ExitEng;
    [SerializeField] private Text _HomeUKR;
    [SerializeField] private Text _HomeEng;
    [SerializeField] private Text _LuseUKR;
    [SerializeField] private Text _LuseEng;
    [SerializeField] private Text _WatchUKR;
    [SerializeField] private Text _WatchEng;
    [SerializeField] private Text _HarderUKR;
    [SerializeField] private Text _HarderEng;
    [SerializeField] private Text _CongratUKR;
    [SerializeField] private Text _CongratEng;

    // Start is called before the first frame update
    void Awake()
    {
        //  _checkLeng = PlayerPrefs.GetInt("_checkLeng");
        //  PlayerPrefs.SetInt("_checkLeng", _checkLeng);

        if(Application.systemLanguage == SystemLanguage.Russian || Application.systemLanguage == SystemLanguage.Ukrainian) 
        {
            //_checkLeng = 0;
            _ContinueUKR.gameObject.SetActive(true);
            _ContinueEng.gameObject.SetActive(false);
            _ExitUKR.gameObject.SetActive(true);
            _ExitEng.gameObject.SetActive(false);
            _HomeUKR.gameObject.SetActive(true);
            _HomeEng.gameObject.SetActive(false);
            _LuseUKR.gameObject.SetActive(true);
            _LuseEng.gameObject.SetActive(false);
            _WatchUKR.gameObject.SetActive(true);
            _WatchEng.gameObject.SetActive(false);
            _HarderUKR.gameObject.SetActive(true);
            _HarderEng.gameObject.SetActive(false);
            _CongratUKR.gameObject.SetActive(true);
            _CongratEng.gameObject.SetActive(false);
        }
        else if(Application.systemLanguage == SystemLanguage.English ) 
        {
           // _checkLeng = 1;
            _ContinueUKR.gameObject.SetActive(false);
            _ContinueEng.gameObject.SetActive(true);
            _ExitUKR.gameObject.SetActive(false);
            _ExitEng.gameObject.SetActive(true);
            _HomeUKR.gameObject.SetActive(false);
            _HomeEng.gameObject.SetActive(true);
            _LuseUKR.gameObject.SetActive(false);
            _LuseEng.gameObject.SetActive(true);
            _WatchUKR.gameObject.SetActive(false);
            _WatchEng.gameObject.SetActive(true);
            _HarderUKR.gameObject.SetActive(false);
            _HarderEng.gameObject.SetActive(true);
            _CongratUKR.gameObject.SetActive(false);
            _CongratEng.gameObject.SetActive(true);
        }
        else 
        {
            //_checkLeng = 1;
            _ContinueUKR.gameObject.SetActive(false);
            _ContinueEng.gameObject.SetActive(true);
            _ExitUKR.gameObject.SetActive(false);
            _ExitEng.gameObject.SetActive(true);
            _HomeUKR.gameObject.SetActive(false);
            _HomeEng.gameObject.SetActive(true);
            _LuseUKR.gameObject.SetActive(false);
            _LuseEng.gameObject.SetActive(true);
            _WatchUKR.gameObject.SetActive(false);
            _WatchEng.gameObject.SetActive(true);
            _HarderUKR.gameObject.SetActive(false);
            _HarderEng.gameObject.SetActive(true);
            _CongratUKR.gameObject.SetActive(false);
            _CongratEng.gameObject.SetActive(true);
        }
    }
}
