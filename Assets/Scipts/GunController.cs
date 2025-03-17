using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab; // Assign your bullet prefab in the inspector
    public Transform firePoint;     // Empty GameObject at the gun's barrel for bullet spawn position
    public float bulletSpeed = 20f;
    public float fireRate = 0.5f;   // Delay between shots

    private float nextFireTime;

    void Update()
    {
        if (!Input.GetButtonDown("Fire1") || !(Time.time >= nextFireTime)) return;
        Shoot();
        nextFireTime = Time.time + fireRate;
    }

    void Shoot()
    {
        if (firePoint != null)
        {
            // Instantiate bullet at firePoint's position and rotation
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

            // Add velocity in the direction the gun faces
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = firePoint.forward * bulletSpeed;
            }

            // Destroy the bullet after 2 seconds
            Destroy(bullet, 2f);
        }
        else
        {
            Debug.LogWarning("FirePoint not assigned on the gun!");
        }
    }
}