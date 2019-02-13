﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCursMove : MonoBehaviour
{

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;
    }
}
