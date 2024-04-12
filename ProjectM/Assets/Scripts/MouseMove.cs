using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    [SerializeField] private float CamXSpeed = 5f;
    [SerializeField] private float CamYSpeed = 3f;

    private float limitMinX = -80f;
    private float limitMaxX = 50f;

    private float eulerAngleX;
    private float eulerAngleY;
 
    public void CalculateRotation(float mouseX, float mouseY)
    {
        eulerAngleY += mouseX * CamYSpeed;
        eulerAngleX -= mouseY * CamYSpeed;
        eulerAngleX = ClampAngle(eulerAngleX, limitMinX, limitMaxX);
        transform.rotation = Quaternion.Euler(eulerAngleX, eulerAngleY, 0);
    }

    private float ClampAngle(float angle, float min, float max)
    {
        if(angle < -360f)
        {
            angle += 360f;
        }

        if (angle > 360f)
        {
            angle -= 360f;
        }

        return Mathf.Clamp(angle, min, max);
    }
}
