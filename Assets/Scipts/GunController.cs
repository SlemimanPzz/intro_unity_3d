using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float fireRate = 0.5f;

    private float _nextFireTime;

    [Header("Gun Settings")]
    public string gunName;            // Unique name for each gun
    public bool isEquipped = false;   // Tracks if this gun is equipped

    void Update()
    {
        if (!isEquipped || !Input.GetButtonDown("Fire1") || !(Time.time >= _nextFireTime)) return;
        Shoot();
        _nextFireTime = Time.time + fireRate;
    }

    void Shoot()
    {
        if (firePoint == null) return;
        var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        var rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = firePoint.forward * bulletSpeed;
        }

        Destroy(bullet, 2f);
    }
}