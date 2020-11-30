using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTimer : MonoBehaviour
{
    float count = 3000.0f;

    private AudioSource audioSource;
    public AudioClip bombExplosion;

    BombSpawner bombSpawner;

    bool bombSound = false;

    void Start()
    {     
        bombSpawner = GameObject.Find("BombSpawner").GetComponent<BombSpawner>();    
        
        audioSource = GetComponent<AudioSource>();
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = bombExplosion;


    }

    void Update()
    {
        count -= Time.deltaTime;

        if (count <= 0.0f)
        {
            AudioSource.PlayClipAtPoint(bombExplosion, transform.position);

            bombSpawner.bombAlive = false;

            Destroy(gameObject);
        }
    }
}
