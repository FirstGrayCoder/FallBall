using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private string nameLevel;
    private string levelEng = "Level: ";
    private string levelUkr = "Рівень: ";
    public Text textNumberLevel;
    // Start is called before the first frame update
    void Start()
    {
        if(Application.systemLanguage == SystemLanguage.Russian || Application.systemLanguage == SystemLanguage.Ukrainian)
        {
            nameLevel = levelUkr;
        }
        else nameLevel = levelEng;
        textNumberLevel.text = nameLevel + SceneManager.GetActiveScene().buildIndex.ToString();
    }
}
