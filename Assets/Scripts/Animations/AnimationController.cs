using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private GameObject _extraLifePanel;
    void Start()
    {
        
        _extraLifePanel.SetActive(false);
    }

    public void OpenExtraLife()
    {
        _extraLifePanel.SetActive(true);
        //_extraLifePanel.GetComponent<Animator>().Play("ExtraLifeAnim");
    }
    public void CloseExtraLife()
    {
        _extraLifePanel.GetComponent<Animator>().Play("ExtraLifeExitAnim");
        StartCoroutine(WaitaSec());
    }

    IEnumerator WaitaSec()
    {
        yield return new WaitForSeconds(0.4f);
        _extraLifePanel.SetActive(false);
    }
    


    // Start is called before the first frame update
    // public void Second()
    // {
    //     HelpSign.link.second.SetActive(true);
    // }

    // // Update is called once per frame
    // public  void Three()
    // {
    // HelpSign.link.third.SetActive(true);
    // }

}
