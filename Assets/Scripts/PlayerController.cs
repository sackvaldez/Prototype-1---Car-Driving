using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    public float Speed = 50.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = UnityEngine.Input.GetAxis("Horizontal");
        forwardInput = UnityEngine.Input.GetAxis("Vertical");

        // Move the vehicle forward according time and speed variable
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwardInput);
        // Turn right or left depending on the turnSpeed variable and horizontalInput value
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
