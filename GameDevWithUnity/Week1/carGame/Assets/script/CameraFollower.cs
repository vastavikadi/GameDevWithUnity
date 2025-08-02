using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform cameraTransform;
    public Transform carTransform;

    void Update()
    {
        
        cameraTransform.position = carTransform.position;

    }
}
