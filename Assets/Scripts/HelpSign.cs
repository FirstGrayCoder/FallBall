using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class HelpSign : MonoBehaviour
{
    public static HelpSign link;
    //public Text helpText;
    public GameObject second;
    public GameObject third;
    [SerializeField] private GameObject _panelHelp;
    // Start is called before the first frame update
    void Start()
    {

        _panelHelp.SetActive(true);
        second.SetActive(false);
        third.SetActive(false);
        
    }

    public void CloseHelp()
    {
        _panelHelp.SetActive(false);
    }
    public void Second()
    {
    second.SetActive(true);
    }

    // Update is called once per frame
    public  void Three()
    {
    third.SetActive(true);
    }


}
