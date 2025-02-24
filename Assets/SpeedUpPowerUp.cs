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
        Destroy(gameObject); // Destroy power-up after activation
    }


    IEnumerator SpeedUp(Player target)
    {
        Debug.Log("Speed is " + target.walkSpeed);
        target.walkSpeed *= speed;
        target.runSpeed *= speed;
        Debug.Log("Speed is " + target.walkSpeed);
        yield return new WaitForSeconds(duration);
        target.walkSpeed /= speed;
        target.runSpeed /= speed; 
        Debug.Log("Ended :Speed is " + target.walkSpeed);
    }
}