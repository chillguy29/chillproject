using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private Camera cam;
    private void Start()
    {
        cam = Camera.main;
    }
    public void Flip()
    {
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if ((mousePos.x < transform.position.x && transform.localScale.x > 0) ||
            (mousePos.x > transform.position.x && transform.localScale.x < 0))
        {
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }
    }
}
