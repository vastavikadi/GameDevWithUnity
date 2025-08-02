using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform cartransform;//got the cars position

    void LateUpdate()
    {
        transform.position = new Vector3(cartransform.position.x, cartransform.position.y, -10f);//simply chnging the x ad y position of the camera and keeping the z same (for the top view but with the car moving and camera following it )
    }
}
