using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject Main_Menu_Panel;
    public GameObject Level_Selection_Panel;
    public GameObject Exit_Panel;
    public GameObject Loading_Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
       if( PlayerPrefs.GetInt("on_Level_selec") == 1)
        {
            Play_Button();
            PlayerPrefs.SetInt("on_Level_selec", 0);
        }
       else if (PlayerPrefs.GetInt("on_Level_selec") == 0)
        {
           // Debug.LogError("nothing");
        }
        Adsmanager.Instance.LoadInterstitial();
        Adsmanager.Instance.ShowInterstitial();
        Adsmanager.Instance.DisplayBanner();

    }
    public void Play_Button()
    {
        Main_Menu_Panel.SetActive(false);
        Loading_Panel.SetActive(true);
        Level_Selection_Panel.SetActive(true);
    }
    public void Exit_Button()
    {
        Exit_Panel.SetActive(true);
    }
}
