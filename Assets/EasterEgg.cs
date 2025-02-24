using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    public GameObject puntoExtra;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        puntoExtra.SetActive(true);
    }

    private void OnMouseExit()
    {
        puntoExtra.SetActive(false);
    }
}
