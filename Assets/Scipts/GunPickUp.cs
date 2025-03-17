using UnityEngine;

public class GunPickUp : MonoBehaviour
{
    public GameObject gunModel;
    public string gunName;            
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        var gunHolder = other.transform.Find("Holder");

        if (gunHolder == null) return;
        var allGuns = gunHolder.GetComponentsInChildren<GunController>();

        foreach (var gun in allGuns) { gun.isEquipped = false; }

        var equippedGun = Instantiate(gunModel, gunHolder.position, gunHolder.rotation);
        equippedGun.transform.SetParent(gunHolder);

        var equippedGunController = equippedGun.GetComponent<GunController>();
        print(equippedGunController.isEquipped);
        equippedGunController.isEquipped = true;

        gameObject.SetActive(false);
    }
}