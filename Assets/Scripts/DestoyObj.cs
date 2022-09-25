using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestoyObj : MonoBehaviour
{
    public static DestoyObj link;
    [SerializeField] private Sprite FullHeart;
    [SerializeField] private Sprite EmptyHeart;
    public Image[] Harts;
    [SerializeField] private GameObject _panelLose;
    [SerializeField] private GameObject _sphere;
    public GameObject _panelWin;
    [SerializeField] private GameObject ButtonsLose;
    [SerializeField] private Rigidbody2D _rbSphere;
    [SerializeField] private Button ButtonPlay;
    [SerializeField] private GameObject ButtonPlaySprite;
    [SerializeField] private int _percentVideo;
    [SerializeField] private int _percentVideo2;
    [SerializeField] private GameObject _objSphere;
    [SerializeField] private GameObject _objPoint;
    [SerializeField] private Vector2 _startPosition;
    [SerializeField] private Button _restButton;
     [SerializeField] private Button _restButtonGame;
    [SerializeField] private GameObject _panelPause;
    [SerializeField] private Collider2D _spherCollider;
    //public GameObject watchVideoForLife;
    public static int Health;
    public int varHealth;
    int i;
    


    void Awake()
    {
        link = this;
        _startPosition = _objPoint.transform.position;
        _percentVideo = 2;
        _percentVideo2 = 4;
        _panelLose.SetActive(false);
        _panelWin.SetActive(false);
        _rbSphere.gravityScale = 0;
        ButtonPlay.enabled = true;
        ButtonsLose.SetActive(false);
        _panelPause.SetActive(false);
        RewardVideo.L.LoadRAd();
        _spherCollider.isTrigger = true;
        
  
    }
    void Start() 
    {
        if (PlayerPrefs.HasKey("health"))
        {
            Health = PlayerPrefs.GetInt("health", Health);
            Debug.Log(" ----- Key HELTH is True Helth =" + Health);
        }
          if (PlayerPrefs.HasKey("health") && Health == 0)
        {
            _restButton.interactable = false;
            //watchVideoForLife.SetActive(true);
        }

        else if (!PlayerPrefs.HasKey("health"))
        {
            Health = 3;
        }
        InterstitialAds.U.LoadAd();
        BannerAds.U.LoadBanner();
        //watchVideoForLife.SetActive(false);
    }

    public void AfterRevardVideo()
    {
        Health = 3;
        PlayerPrefs.SetInt("health", Health);
        PlayerPrefs.Save();
    }

    void FixedUpdate()
    {
        if(Health > DontDestroy.GetInstance().NumofHealth) {
            Health = DontDestroy.GetInstance().NumofHealth;
        } 
        for(i = 0; i < Harts.Length; i++) 
        {
            if (i < Health)
            {
               Harts[i].sprite = FullHeart;
               //Debug.Log("----------IIIIIIIIIII = " + i + Health );
            }
            else 
            {
                Harts[i].sprite = EmptyHeart;
                //Debug.Log("----------IIIBBBBBBBIIII = " + i  + Health);
            }
            // if (i < DontDestroy.GetInstance().NumofHealth) 
            // {
            //     Harts[i].enabled = true;
            // }
            // else 
            // {
            //     Harts[i].enabled = false;
            // }
        }
        if(Health <= 0)
        {
            _restButtonGame.interactable = false;
            _panelLose.SetActive(true);
            _panelWin.SetActive(false);
            ButtonsLose.SetActive(true);
            ButtonPlaySprite.SetActive(false);
            _restButton.interactable = false;
        }
        else if(Health >= 1)
        {
            _restButton.interactable = true;
            _restButtonGame.interactable = true;
            //watchVideoForLife.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Respawn"){
            _panelLose.SetActive(true);
            _sphere.SetActive(false);
            ButtonsLose.SetActive(true);
            Health--;
            PlayerPrefs.SetInt("health", Health);
            PlayerPrefs.Save();
            if (Health <= 0)
            {
                _restButton.interactable = false;
                //watchVideoForLife.SetActive(true);
            }
            _spherCollider.isTrigger = true;

        }
        else if (other.tag == "Finish"){
            _sphere.SetActive(false);
            _panelWin.SetActive(true);
            int randnum = Random.Range(0, 5);
            Debug.Log(" This is random number   = " + randnum); 
            if (randnum == _percentVideo || randnum == _percentVideo2) 
            {
            InterstitialAds.U.ShowAd();
            } 
            ChengLevels.UnlockLevel();
        }
    }
    public void DelPrefs()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    // IEnumerator Waite()
    // {
    //     yield return new WaitForSeconds(2);
    //     LevelManager.PlayGame();
    // }

    public void Play() 
    {
        if (_rbSphere.bodyType ==  RigidbodyType2D.Static)
        {
            _rbSphere.bodyType =  RigidbodyType2D.Dynamic;
        }
        _rbSphere.gravityScale = 1;
        ButtonPlaySprite.SetActive(false);
        ButtonPlay.enabled = false;
        _spherCollider.isTrigger = false;
    }
    public void Rest()
    {
        _objSphere.transform.position = _startPosition; 
        _rbSphere.gravityScale = 0;
        _sphere.SetActive(true);
        _panelLose.SetActive(false);
        ButtonsLose.SetActive(false);
        ButtonPlay.enabled = true;
        ButtonPlaySprite.SetActive(true);
        _spherCollider.isTrigger = true;
    }
    public void ResumeButton()
    {
        _rbSphere.bodyType = RigidbodyType2D.Static;
        Health--;
        PlayerPrefs.SetInt("health", Health);
        PlayerPrefs.Save();
        if (Health <= 0)
        {
            _restButton.interactable = false;
            //watchVideoForLife.SetActive(true);
        }
        _objSphere.transform.position = _startPosition; 
        _rbSphere.gravityScale = 0;
        _sphere.SetActive(true);
        ButtonPlay.enabled = true;
        ButtonPlaySprite.SetActive(true);
        _spherCollider.isTrigger = true;
    }
}
