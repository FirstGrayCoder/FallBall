using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
   [SerializeField] private GameObject _levelPanel;

    public void Awake()
    {
        _levelPanel.SetActive(false);
    }
    
    public void ExitGame() 
    {
        Application.Quit();
    }
    public void PlayBut() 
    {
        _levelPanel.SetActive(true);
    }

    public void DelPrefs()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitPanel()
        {
            _levelPanel.SetActive(false);
        }
    

}
