using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffected : MonoBehaviour
{
    float countdown = 5f;
    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0)
        {
            Destroy(gameObject);
        }
    }
}
