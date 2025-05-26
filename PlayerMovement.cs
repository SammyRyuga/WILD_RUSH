using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 2f;
    public float horizontalSpeed = 3f;
    public float rightLimit = 10f;
    public float leftLimit = -10f;

    void Update()
    {
        // Forward 
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

        // Move Left
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x > leftLimit)
        {
            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed, Space.World);
        }

        // Move Right
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && transform.position.x < rightLimit)
        {
            transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed, Space.World);
        }
    }
}