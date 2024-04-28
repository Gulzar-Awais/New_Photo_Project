using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Off_The_Obj : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        Invoke("Off", 1.5f);
    }
    public void Off()
    {
        this.gameObject.SetActive(false);
    }
}
