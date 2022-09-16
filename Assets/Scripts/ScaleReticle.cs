using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleReticle : MonoBehaviour
{
    public float scaleSpeed = 0.05f;
    public float maxScale = 1.2f;
    public float minScale = 1;
    private Vector3 scaleVector;
    private bool isScalingUp = true;

    // Start is called before the first frame update
    void Start()
    {
        scaleVector = new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (isScalingUp)
        {
            transform.localScale += scaleVector;
            if (transform.localScale.x > maxScale)
                isScalingUp = false;
        }
        else
        {
            transform.localScale -= scaleVector;
            if (transform.localScale.x < minScale)
                isScalingUp = true;
        }
    }
}
