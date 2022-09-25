using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInit : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] private string _androidGameId = "4661334";
    [SerializeField] private string _iOSGameId = "4661335";
    private string _gameId;
    
   void Awake()
   {
       InitilizedAds();
   }

    public void InitilizedAds()
    {
        _gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
        ? _iOSGameId
        : _androidGameId;

        Advertisement.Initialize(_gameId);
    } 
    public void OnInitializationComplete()
    {
        //Debug.Log("Initilized Ads is Complete");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log("Initilized Ads is Failed" + error.ToString() + message);;
    }
}
