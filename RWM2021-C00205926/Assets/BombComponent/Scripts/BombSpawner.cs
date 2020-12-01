using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bomb;
    private GameObject bombRef;
    public bool bombAlive;

    private AudioSource audioSource;
    public AudioClip bombPlant;

    BombTimer bombTimer;

    float count = 1f;

    void Start()
    {        
        audioSource = GetComponent<AudioSource>();
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = bombPlant;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
 
            if (bombAlive == false)
            {           
                count -= Time.deltaTime;
                Debug.Log(bomb);
                Instantiate(bomb, transform.position, Quaternion.identity);
                audioSource.clip = bombPlant;
                audioSource.Play();
                bombAlive = true;
            }
        }
    }
}
