using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ADSManager : MonoBehaviour, IUnityAdsShowListener
{
    private string _progectId = "4661334";
    private string _video = "Interstitial_Android";
    private string _rewardVideo = "Rewarded_Android";
    private string _baner = "Banner_Android";
    // Start is called before the first frame update
    void Start()
    {
        //Advertisement.AddListener(this); #не спрацювало
        Advertisement.Initialize(_progectId);

        StartCoroutine(ShowBannerWhenInitialized());
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER) ;
    }


    public static void ShowAdsVideo(string placementId)
    {
        if(Advertisement.isInitialized)
        {
            Advertisement.Show(placementId);
        }

        else
        {
            Debug.Log("No ADS");
        }
    }

    IEnumerator ShowBannerWhenInitialized ()
    {
        while (!Advertisement.isInitialized)
        {
        yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(_baner);
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowComplete(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished )
        {
            Debug.Log("polu4ilos");
        }
        else if (showResult == ShowResult.Skipped )
        {

        }
        else if (showResult == ShowResult.Failed )
        {

        }
        else
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        throw new System.NotImplementedException();
    }
    // Update is called once per frame


}
