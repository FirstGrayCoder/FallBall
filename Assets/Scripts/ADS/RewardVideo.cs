using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;


public class RewardVideo : MonoBehaviour, IUnityAdsShowListener, IUnityAdsLoadListener
{
    public static RewardVideo L;
    [SerializeField] private string _androidRewarded = "Rewarded_Android";
    [SerializeField] private string _iOSRewarded = "Rewarded_iOS";
    [SerializeField] private Button _restButton;
    [SerializeField] private Button _rewVideo;
    private string _adsPlacementID;
    
    void Awake()
    {
        L = this;
        _adsPlacementID = (Application.platform == RuntimePlatform.IPhonePlayer)
        ? _iOSRewarded
        : _androidRewarded;
    }

    public void LoadRAd()
    {
        Advertisement.Load(_adsPlacementID, this);
    }

    public void ShowRAd()
    {
        Advertisement.Show(_adsPlacementID, this);
        //DestoyObj.link.AfterRevardVideo();
        _restButton.interactable = true;
        Advertisement.Load(_adsPlacementID, this);
    }

    //Ads LOAD
    public void OnUnityAdsAdLoaded(string placementId)
    {
        _rewVideo.interactable = true;
    }
    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        _rewVideo.interactable = false;
        Debug.Log($"Ads Load is Failed {error.ToString()} - {message}");
    }

    //Ads Show
    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {

        if(placementId.Equals(_adsPlacementID) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {
            DestoyObj.link.AfterRevardVideo();
            LoadRAd();
        }
        // Debug.Log(" Placement ID  = " + placementId + " _ADSPlasmentID  =" + _adsPlacementID);

    }
    public void OnUnityAdsShowClick(string placementId){}
    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        LoadRAd();
    }
    public void OnUnityAdsShowStart(string placementId){}

}
