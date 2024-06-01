using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float Speed = 50.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Here we get Player Input
        horizontalInput = UnityEngine.Input.GetAxis("Horizontal");
        forwardInput = UnityEngine.Input.GetAxis("Vertical");

        // Move the vehicle forward according time and speed variable
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwardInput);
        /* SUSTITUIDA: Turn right or left depending on the turnSpeed variable and horizontalInput value
            transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); */

        // Eliminate the sliding effect while turning
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
    }
}
