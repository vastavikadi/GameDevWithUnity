using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public float rotationSpeed=5;
    public float moveSpeed=1;
    public Transform carTransform;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Debug.Log("Horizontal Input: " + horizontalInput + ", Vertical Input: " + verticalInput);

        if (Mathf.Abs(horizontalInput) > 0.1f)
        {
            carTransform.Rotate(0f, 0f, -rotationSpeed * horizontalInput * Time.deltaTime);
        }

        if (Mathf.Abs(verticalInput) > 0.1f)
        {
            carTransform.Translate(0f, moveSpeed * verticalInput * Time.deltaTime, 0f);
        }
    }
}
