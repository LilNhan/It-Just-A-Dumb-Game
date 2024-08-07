using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WeaponControllerWithDrag : MonoBehaviour
{
    public Transform mainCharacter; // Tham chiếu đến Main Character
    public float rotationSpeed = 5f; // Tốc độ xoay của vũ khí

    private void Update()
    {
        RotateWeaponToMousePosition();
        MoveWeaponWithCharacter();
    }

     void RotateWeaponToMousePosition()
    {
        // Lấy vị trí chuột trên màn hình
        Vector3 mousePos = Input.mousePosition;

        // Chuyển đổi vị trí chuột từ màn hình sang thế giới 2D
        Vector3 worldPos = Camera.main.ScreenPointToRay(mousePos).origin;
        worldPos.z = 0f; // Đảm bảo vũ khí chỉ xoay trên mặt phẳng 2D

        // Tính toán góc xoay cần thiết để hướng vũ khí về phía chuột
        Vector3 direction = (worldPos - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

     void MoveWeaponWithCharacter()
    {
       
        transform.position = new Vector3(mainCharacter.position.x , mainCharacter.position.y +1f , transform.position.z);
    }

    
}