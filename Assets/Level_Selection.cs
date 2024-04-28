using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Selection : MonoBehaviour
{
    public GameObject Main_Menu_Panel;
    public GameObject Level_Selection_Panel;
    public GameObject Loading_Panel;

    public void Back_Button()
    {
        Main_Menu_Panel.SetActive(true);
        Loading_Panel.SetActive(true);
        Level_Selection_Panel.SetActive(false);
    } 
    public void Select_Level(int i)
    {
        Loading_Panel.SetActive(true);
        PlayerPrefs.SetInt("level", i);
        SceneManager.LoadScene(1);
    //
    }
}