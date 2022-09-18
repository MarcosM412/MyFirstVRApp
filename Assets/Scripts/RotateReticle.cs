using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateReticle : MonoBehaviour
{
    public float rotationSpeed = 100;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime * rotationSpeed, 0));
    }
}
