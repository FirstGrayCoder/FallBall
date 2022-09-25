using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{

    // Update is called once per frame
    public void RestBut()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
