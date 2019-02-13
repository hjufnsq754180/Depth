using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    [SerializeField] GameObject Particle;

    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(Particle, new Vector2(Random.Range(-9f, 9f), -90), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
