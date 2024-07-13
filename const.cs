using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Const
{
    public static float Speed_Original = 5f;
   
    public static float jumpForce = 600f; // Lực nhảy
    public static float gravity = 0.3f; // Gia tốc trọng lực
    public static float jumpDuration = 3f; // Thời gian nhảy
    private static float currentJumpTime = 0f; // Thời gian nhảy hiện tại
    private static bool isJumping = false; // Cờ kiểm tra trạng thái nhảy
}
