using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    //left and right keys along with a/d keys rotate the car
    //up and down keys along with the w/s keys move the car forward and backward
    public float rotationSpeed, movingSpeed;
    public Transform carTransform;

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Debug.Log("horizontal:" + horizontalMovement + "vertical:" + verticalMovement);

        if (Math.Abs(horizontalMovement) > 0.01f)
        {
            carTransform.Rotate(0f, 0f, -(rotationSpeed * horizontalMovement));
        }
        if (Math.Abs(verticalMovement) > 0.01f)//it is not else if because the user can press the up/down key and right/left key at the same time
        {
            carTransform.Translate(0f, movingSpeed * verticalMovement, 0f);
        }
    }
}
