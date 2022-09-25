using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAds : MonoBehaviour
{
    public static BannerAds U;
    [SerializeField] private BannerPosition _bannerPosition = BannerPosition.BOTTOM_CENTER;
    [SerializeField] private string _bannerAndroid = "Banner_Android";
    [SerializeField] private string _banneriOS = "Banner_iOS";

    private string _gameID;
    // Start is called before the first frame update

    private void Awake()
    {
        U = this;
        _gameID = (Application.platform == RuntimePlatform.IPhonePlayer)
        ? _banneriOS
        : _bannerAndroid;
        //LoadBanner();
    }
    void Start()
    {
        Advertisement.Banner.SetPosition(_bannerPosition);
       
        StartCoroutine(LoadBannerAfterOneSec());
        
    }

    private IEnumerator LoadBannerAfterOneSec()
    {
        yield return new WaitForSeconds(1f);
         //Advertisement.Banner.Load(_gameID);
        ShowBanner();
    } 

    public void LoadBanner()
    {
        BannerLoadOptions options = new BannerLoadOptions
        {
            loadCallback = OnBannerLoaded,
            errorCallback = OnBannerError
        };

        Advertisement.Banner.Load(_gameID, options);
        //Debug.Log("-----First Banner Loaded-----  " + _gameID);
    }

    private void OnBannerLoaded()
    {
        //Debug.Log("-----Banner Loaded-----");
        ShowBanner();
        //Advertisement.Banner.Load(_gameID);
    }

    private void OnBannerError(string message)
    {
        //Debug.Log($"----Banner Load Error {message}");
    }

    public void ShowBanner()
    {
        BannerOptions options = new BannerOptions
        {
            clickCallback = OnBannerClicked,
            showCallback = OnBannerShown,
            hideCallback = OnBannerHidden
        };

        Advertisement.Banner.Show(_gameID, options);
        //Debug.Log("-----OnBannerShow------ Showbanner " + _gameID);
        //Advertisement.Banner.Load(_gameID);
    }
    private void OnBannerClicked(){}
    private void OnBannerShown(){
        //ShowBanner();
        //Debug.Log("-----OnBannerShown------ Showbanner");
    }
    private void OnBannerHidden(){}
    // Update is called once per frame
    public void HideBanner()
    {
        //Advertisement.Banner.Hide();
    }
}
