using UnityEngine.Advertisements;
using UnityEngine;

public class InterstitialAds : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    public static InterstitialAds U;
    [SerializeField] private string _androidInterstitial = "Interstitial_Android";
    [SerializeField] private string _iOSInterstitial = "Interstitial_iOS";
    //[SerializeField] private bool _testMode;
    private string _adsIPlacementID;
    
    void Awake()
    {
        U = this;
        _adsIPlacementID = (Application.platform == RuntimePlatform.IPhonePlayer)
        ? _iOSInterstitial
        : _androidInterstitial;
    }

    public void LoadAd()
    {
        Advertisement.Load(_adsIPlacementID, this);
    }

    public void ShowAd()
    {
        Advertisement.Show(_adsIPlacementID, this);
        Debug.Log(_androidInterstitial);
    }


    //Ads LOAD
    public void OnUnityAdsAdLoaded(string placementId){}
    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        //Debug.Log($"Ads Load is Failed {error.ToString()} - {message}");
    }

    //Ads Show
    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        LoadAd();
    }
    public void OnUnityAdsShowClick(string placementId){}
    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message){}
    public void OnUnityAdsShowStart(string placementId){}


}
