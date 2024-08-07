using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Lấy input từ bàn phím
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Tính toán vector di chuyển
        Vector3 movement = new Vector3(horizontal, vertical, 0f);

        // Di chuyển player
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}