using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChengLevels : MonoBehaviour
{
    public void HomeButton ()
    {
        SceneManager.LoadScene(0);
    } 
    public void ExitGame() 
    {
        Application.Quit();
    }

    static public void UnlockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        if(currentLevel >= PlayerPrefs.GetInt("Levels"))
        {
            PlayerPrefs.SetInt("Levels", currentLevel +1);
        }
    }

        public static void PlayGame ()
    {
        //Debug.Log("----------Before Load level Health = " + DestoyObj.Health + " Level --" + SceneManager.GetActiveScene().buildIndex);
        DestoyObj.Health = PlayerPrefs.GetInt("health", DestoyObj.Health);
        //Debug.Log("----------Get Int  Health = " + DestoyObj.Health + " Level --" + SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        //Debug.Log("----------After Load Scene Health = " + DestoyObj.Health + " Level --" + SceneManager.GetActiveScene().buildIndex);
        
        Time.timeScale = 1;
    } 



}
