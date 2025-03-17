using UnityEngine;

public class GunPickUp : MonoBehaviour
{
    public GameObject gunModel; 
    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return; 
        var gunHolder = other.transform.Find("Holder");

        if (gunHolder == null) return;
        var newGun = Instantiate(gunModel, gunHolder.position, gunHolder.localRotation);

        newGun.transform.SetParent(gunHolder);

        gameObject.SetActive(false);
    }
}
