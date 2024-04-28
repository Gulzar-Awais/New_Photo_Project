using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onenabling : MonoBehaviour
{
    public GameObject Hint;
    private void OnEnable()
    {
        Hint.SetActive(true);
    }
}
