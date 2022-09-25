using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextOpenLevel : MonoBehaviour
{
    //public Button [] Levels;
    public void LoadTo(int Level)
    {
        SceneManager.LoadScene(Level);
        Time.timeScale = 1;
    }
}
