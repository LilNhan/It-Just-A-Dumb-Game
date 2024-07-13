using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject trackedObject; // Đối tượng cần theo dõi
    private Vector3 offsetPosition; // Vị trí camera tương đối so với đối tượng

    void Start()
    {
        // Tính toán vị trí camera tương đối so với đối tượng
        offsetPosition = transform.position - trackedObject.transform.position;
    }

    void LateUpdate()
    {
        // Cập nhật vị trí camera để luôn đi theo z của đối tượng
        transform.position = trackedObject.transform.position + offsetPosition;
    }
}