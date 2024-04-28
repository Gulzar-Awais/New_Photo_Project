using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading_Panel : MonoBehaviour
{
    public Slider Loading_Slider;
    public float Slider_Value;
    void Update()
    {
       if(Loading_Slider.value >= 1)
        {
            this.gameObject.SetActive(false);
        }
       else
        {
            Slider_Value += Time.deltaTime * 0.4f;
            Loading_Slider.value = Slider_Value;
        }
    }
    private void OnDisable()
    {
        Slider_Value = 0f;
        Loading_Slider.value = 0f;
    }
}
