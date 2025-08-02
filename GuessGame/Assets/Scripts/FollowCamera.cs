using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;      // The car to follow
    public Vector3 offset;        // Offset between the camera and the car
    public float smoothSpeed = 0.125f; // How smooth the camera moves

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

        //keep camera looking at the car
        // transform.LookAt(target);
    }
}
