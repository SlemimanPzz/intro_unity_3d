using System;
using System.Collections;
using UnityEngine;

public class SpeedUpPowerUp : MonoBehaviour
{
    
    public float speed;
    public float duration;
    
    private void OnTriggerEnter(Collider collision)
    {
        var player = collision.GetComponent<Player>();
        if (player == null) return;
        Debug.Log($"Player detected{player.name}! Activating speed boost.");
        StartCoroutine(SpeedUp(player));
    }


    IEnumerator SpeedUp(Player target)
    {
        
        Collider collider = GetComponent<Collider>();
        if (collider != null) collider.enabled = false;
        
        Renderer[] powerUpRenderers = GetComponentsInChildren<Renderer>();
        foreach (var r in powerUpRenderers)
        {
            r.enabled = false; 
        }
        
        
        target.walkSpeed *= speed;
        target.runSpeed *= speed;
        
        yield return new WaitForSeconds(duration);
        
        target.walkSpeed /= speed;
        target.runSpeed /= speed; 
        
        
        Destroy(gameObject);
    }
}