using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public bool Click_picture;
    public GameObject[] Levels;
    public GameObject Level_Complete_panel, Level_Fail_panel;
    public ParticleSystem Boom;
    // Start is called before the first frame update
    void Start()
    {
        All_Levels_set();
        Levels[PlayerPrefs.GetInt("level", 0)].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void All_Levels_set()
    {
        for(int i = 0; i<Levels.Length; i++)
        {
            Levels[i].SetActive(false);
        }
    }
    public void Level_Complete()
    {
        PlayerPrefs.SetInt("on_Level_selec", 1);
        SceneManager.LoadScene(0);
    }
    public void Level_Fail()
    {
        PlayerPrefs.SetInt("on_Level_selec", 1);
        SceneManager.LoadScene(0);
    }
    public void Click_Picture()
    {
        if(Click_picture == true)
        {
            Boom.gameObject.SetActive(true);
            Boom.Play();
            StartCoroutine(start_complete());
        }
        else
        {
            Level_Fail_panel.SetActive(true);
        }
    }
    IEnumerator start_complete()
    {
        yield return new WaitForSeconds(2f);
        Level_Complete_panel.SetActive(true);
    }
}


   