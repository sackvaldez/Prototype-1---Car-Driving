using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject propeller;
    public float PropellerSpeed = 5.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * PropellerSpeed);
    }
}
