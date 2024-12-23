using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTowardMouse : MonoBehaviour
{
    Camera cam;
    public Vector2 MousePos
    {
        get
        {
            Vector2 pos = cam.ScreenToWorldPoint(Input.mousePosition);
            return pos;
        }
    }

    private void Awake()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        Vector2 dir = (Vector2)transform.position - MousePos;
        float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);
        transform.eulerAngles = new Vector3(0f, 0f, angle+180);
    }

}