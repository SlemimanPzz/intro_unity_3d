using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Destructable")) return;
        other.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}