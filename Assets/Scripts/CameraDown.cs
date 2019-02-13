using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDown : MonoBehaviour
{
    [SerializeField] float Speed = 1.5f;
    [SerializeField] int eC;

    void Update()
    {
        eC = FindObjectOfType<Player>().enemyCount;
        if (eC == 2)
        {
            if (transform.position.y > 106)
            {
                transform.Translate(Vector2.down * Speed * Time.deltaTime);
            }
        }

        if (eC == 3)
        {
            if (transform.position.y > 94)
            {
                transform.Translate(Vector2.down * Speed * Time.deltaTime);
            }
        }

        if (eC == 5)
        {
            if (transform.position.y > 75)
            {
                transform.Translate(Vector2.down * Speed * Time.deltaTime);
            }
        }

        if (eC == 10)
        {
            if (transform.position.y > 56)
            {
                transform.Translate(Vector2.down * Speed * Time.deltaTime);
            }
        }

        if (eC == 13)
        {
            if (transform.position.y > 44)
            {
                transform.Translate(Vector2.down * Speed * Time.deltaTime);
            }
        }
    }
}

