using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer sr;
    [SerializeField] GameObject light1;
    [SerializeField] GameObject light2;
    [SerializeField] GameObject light3;
    [SerializeField] GameObject light4;
    [SerializeField] GameObject light5;
    [SerializeField] AudioClip[] aC;



    public int enemyCount = 0;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (enemyCount == 3)
        {
            light1.SetActive(false);
            light2.SetActive(true);
            sr.color = Color.HSVToRGB(0,0, 0.75f);
        }
        if (enemyCount == 5)
        {
            light2.SetActive(false);
            light3.SetActive(true);
            sr.color = Color.HSVToRGB(0, 0, 0.5f);
        }
        if (enemyCount == 10)
        {
            light3.SetActive(false);
            light4.SetActive(true);
            sr.color = Color.HSVToRGB(0, 0, 0.25f);
        }
        if (enemyCount == 13)
        {
            light4.SetActive(false);
            light5.SetActive(true);
            sr.color = Color.HSVToRGB(0, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "Start Light")
        {
            sr.color = Color.white;
            light1.SetActive(true);
        }

        if (coll.gameObject.name == "TriggerAudio")
        {
            FindObjectOfType<Enemy>().PlayAudio(aC);
        }

        if (coll.gameObject.name == "End Enemy")
        {
            sr.color = Color.black;
            Destroy(gameObject, 1f);
        }
    }
}
