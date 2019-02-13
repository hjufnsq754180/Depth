using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveParticle : MonoBehaviour
{
    [SerializeField] float Speed = 3;

    void Update()
    {
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }
}
