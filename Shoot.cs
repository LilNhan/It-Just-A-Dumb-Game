using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform weaponTransform; // Tham chiếu đến GameObject vũ khí
    public GameObject bulletPrefab; // Prefab của viên đạn
    public float bulletSpeed = 10f; // Tốc độ di chuyển của viên đạn
    public float cooldownTime = 0.5f; // Thời gian giữa các lần bắn

    private float lastShootTime = 0f; // Thời gian bắn lần cuối

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time - lastShootTime >= cooldownTime)
        {
            ShootBullet();
            lastShootTime = Time.time;
        }
    }

    private void ShootBullet()
    {
        // Tạo một instance mới của viên đạn
        GameObject bullet = Instantiate(bulletPrefab, weaponTransform.position, Quaternion.Euler(0f, 0f, 90f));

        // Đẩy viên đạn về phía trước
        bullet.GetComponent<Rigidbody2D>().velocity = weaponTransform.right * bulletSpeed;
    }

    
}
