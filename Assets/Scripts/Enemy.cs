using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] AudioSource aS;
    [SerializeField] GameObject enemyLight; 
    [SerializeField] GameObject giveLight;
    [SerializeField] GameObject audioPref;
    
    private void Start()
    {
        AudioSource aS = GetComponent<AudioSource>();   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            enemyLight.SetActive(false);
            giveLight.SetActive(true);
            Destroy(audioPref);
        }
    }

    public void PlayAudio(AudioClip[] aC)
    {
        aS.PlayOneShot(aC[Random.Range(0,13)], 0.2f);
    }
}
