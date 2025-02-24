using System;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    public GameObject puntoExtra;
    
    private void OnMouseOver()
    {
        puntoExtra.SetActive(true);
        
    }

    private void OnMouseExit()
    {
        puntoExtra.SetActive(false);
    }

}
