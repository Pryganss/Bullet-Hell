using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceMovement : MonoBehaviour
{

    [SerializeField]
    Transform rotationCenter;

    [SerializeField]
    float rotationRadius = 2f, angularSpeed = 2f;
    float posX, posY, angle = 0f;
    
    public float elX = 1f, elY = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.rotation.x, transform.rotation.y, angle);
        posX = rotationCenter.position.x + Mathf.Cos (angle) * rotationRadius / elX;
        posY = rotationCenter.position.y + Mathf.Sin (angle) * rotationRadius / elY;
        transform.position = new Vector2 (posX, posY);
        angle = angle + Time.deltaTime * angularSpeed;

        if (angle >= 360f) angle = 0f;


    }
}
