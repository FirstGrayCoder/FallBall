using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy link;
    public static int Health;
    public static int HpForAds;
    public int varHealth;

    //public Text levelNumText;
    public int NumofHealth ;

    public static DontDestroy dontDestroy;

    // Get instance of our 'shared class'
    public static DontDestroy GetInstance() { return dontDestroy; }

    void Awake()
    {
        //varHealth = 3;
        link = this;
        NumofHealth = 3;
        // Health = 3;
        // if (PlayerPrefs.HasKey("health"))
        // {
        //     varHealth = PlayerPrefs.GetInt("health", Health);
        //     Debug.Log(" There are key varHealth  " + varHealth + "There Health  " + Health);
        // }
        // else if (!PlayerPrefs.HasKey("health"))
        // {
        //     Health = 3;
        //     Debug.Log(" There are NO key Health" + Health);
        // }
       
        
        DontDestroyOnLoad(gameObject); // let's make this object permanently exist while our app is launched
        if (dontDestroy == null) // check if our instance ref in null
        { dontDestroy = this; } // this instance becomes the only our instance available
        // ...otherwise check if the control instance is not this one?
        else if (dontDestroy != null) { Destroy(gameObject); } // Re-creating?! Just throw this sh*t away!
    }

    // public void AfterRewardVideo() 
    // {
    //     PlayerPrefs.SetInt("health", 3);
    // }

    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    // Далее в этот класс пихаем всё, что нам требуется таскать по любым сценам приложения...
    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

    // для примера - общедоступная переменная и метод для её увеличения
    [HideInInspector]
    public int cntr = 0; // из любого места можно обратиться к переменной через SharedGameData.GetInstance().cntr;

    public void Inc() // из любого места можно обратиться к функции через SharedGameData.GetInstance().Inc();
    {
        cntr++; 
    }





}
