using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed = 15;

    void Update()
    {
        Vector2 mousePos;
        mousePos.x = Input.mousePosition.x;
        mousePos.y = Camera.main.pixelHeight - Input.mousePosition.x;

        Vector3 point = Camera.main.ScreenToWorldPoint(new Vector3(
            mousePos.x,
            mousePos.y,
            Camera.main.nearClipPlane
        ));

        transform.position = new Vector3(point.x * speed - 133, transform.position.y, transform.position.z);
    }
}

