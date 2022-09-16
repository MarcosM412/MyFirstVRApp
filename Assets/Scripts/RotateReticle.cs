using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateReticle : MonoBehaviour
{
    public float rotationSpeed = 0.5f;
    private Vector3 rotationVector;
    // Start is called before the first frame update
    void Start()
    {
        rotationVector = new Vector3(0, rotationSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationVector);
    }
}
