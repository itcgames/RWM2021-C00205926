using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTile : MonoBehaviour
{
    float countdown = 5f;
    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        
        if(countdown <= 0)
        {
            FindObjectOfType<BreakableObject>().Boom(transform.position);
            Destroy(gameObject);
        }
    }
}
