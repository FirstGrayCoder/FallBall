using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasForScript : MonoBehaviour
{
    public static CanvasForScript link;
    [SerializeField] private GameObject _panelPause;

    void Start()
    {
        link = this;
    }
    public void Pause()
    {
        _panelPause.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        _panelPause.SetActive(false);
        Time.timeScale = 1;
    }

    // public void Corutine()
    // {
    //     StartCoroutine(Waite());
    // }

    // public  IEnumerator Waite()
    // {
    //     yield return new WaitForSeconds(2);
    //     LevelManager.PlayGame();
    // }


}
