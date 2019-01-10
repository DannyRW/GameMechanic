using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{

    protected float fDistance = 1;
    protected float fSpeed = 1;
    public GameObject Enginei4;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) OrbitEnginei4(false);
        if (Input.GetKey(KeyCode.LeftArrow)) OrbitEnginei4(true);
    }

    protected void OrbitEnginei4(bool bLeft)
    {
        float step = fSpeed * Time.deltaTime;
        float fOrbitCircumfrance = 2F * fDistance * Mathf.PI;
        float fDistanceDegrees = (fSpeed / fOrbitCircumfrance) * 360;
        float fDistanceRadians = (fSpeed / fOrbitCircumfrance) * 2 * Mathf.PI;
        if (bLeft)
        {
            transform.RotateAround(Enginei4.transform.position, Vector3.up, -fDistanceRadians);
        }
        else
            transform.RotateAround(Enginei4.transform.position, Vector3.up, fDistanceRadians);
    }
}