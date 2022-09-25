using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static int Levels = 1;
    int levelUnlock;
    public Button[] buttons;

    void Start()
    {
        levelUnlock = PlayerPrefs.GetInt("Levels", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < levelUnlock; i++) 
        {
            buttons[i].interactable = true;
        }
    }

    public void LoadLevel(int levelIndex) 
    {
        if (PlayerPrefs.HasKey("health"))
        {
            DestoyObj.Health = PlayerPrefs.GetInt("health", DestoyObj.Health);
        }
        else if (!PlayerPrefs.HasKey("health"))
        {
            DestoyObj.Health = 3;
        }
        SceneManager.LoadScene(levelIndex);
          
        Time.timeScale = 1;
    }

}
