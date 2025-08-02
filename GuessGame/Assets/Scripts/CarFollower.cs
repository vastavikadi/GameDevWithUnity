using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform carTransform;//got the cars position

    void LateUpdate()
    {
        transform.position = new Vector3(carTransform.position.x, carTransform.position.y, -10);//simply chnging the x ad y position of the camera and keeping the z same (for the top view but with the car moving and camera following it )
    }
}
