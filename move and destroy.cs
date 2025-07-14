using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveanddestroy : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        if (transform.position.z <= -10f)
        {
            Destroy(gameObject);
        }
    }
}

