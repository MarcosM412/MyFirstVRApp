using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleReticle : MonoBehaviour
{
    public float scaleSpeed = 0.4f;
    public float maxScale = 1.2f;
    public float minScale = 1;
    private bool isScalingUp = true;
    private float timeScaleSpeed;

    // Update is called once per frame
    void Update()
    {
        timeScaleSpeed = Time.deltaTime * scaleSpeed;

        if (isScalingUp)
        {
            transform.localScale += new Vector3(timeScaleSpeed, timeScaleSpeed, timeScaleSpeed);
            if (transform.localScale.x > maxScale)
                isScalingUp = false;
        }
        else
        {
            transform.localScale -= new Vector3(timeScaleSpeed, timeScaleSpeed, timeScaleSpeed);
            if (transform.localScale.x < minScale)
                isScalingUp = true;
        }
    }
}
