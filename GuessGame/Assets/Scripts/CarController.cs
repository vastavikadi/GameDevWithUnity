using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class CarController : MonoBehaviour
{
    //left and right keys along with a/d keys rotate the car
    //up and down keys along with the w/s keys move the car forward and backward
    public float rotationSpeed, movingSpeed, boostSpeed;
    public Transform carTransform;

    private bool isBoosting = false;
    public ParticleSystem boostEffect; // drag your particle system here in the Inspector

    private float currentSpeed;

    void Start()
    {
        currentSpeed = movingSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        // Debug.Log("horizontal:" + horizontalMovement + "vertical:" + verticalMovement);

        if (Math.Abs(horizontalMovement) > 0.01f)
        {
            carTransform.Rotate(0f, 0f, -(rotationSpeed * horizontalMovement * Time.deltaTime));
        }
        if (Math.Abs(verticalMovement) > 0.01f)//it is not else if because the user can press the up/down key and right/left key at the same time
        {
            carTransform.Translate(0f, movingSpeed * verticalMovement * Time.deltaTime, 0f);
        }
        if(!isBoosting &&Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.B))//boost activates on left shift + B
        {
            StartCoroutine(Boost());
        }
    }

    IEnumerator Boost()
    {
        isBoosting = true;
        currentSpeed = boostSpeed;
        Debug.Log("Boost Activated!");
        if (boostEffect != null) boostEffect.Play();

        yield return new WaitForSeconds(5f);

        currentSpeed = movingSpeed;
        isBoosting = false;
        Debug.Log("Boost Ended.");

        if (boostEffect != null) boostEffect.Stop();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Car has hit something.");
    }
}
