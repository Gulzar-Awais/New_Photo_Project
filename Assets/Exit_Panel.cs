using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_Panel : MonoBehaviour
{
    public void Yes_Button()
    {
        this.gameObject.SetActive(false);
        Application.Quit();
    }
    public void No_Button()
    {
        this.gameObject.SetActive(false);
    }
}
