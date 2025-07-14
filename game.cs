using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    float x, y, z;
    public GameObject obstacle;

    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            x = Random.Range(-5.99f, 6.6805f);
            y = 1.7047f;
            z = 44.98f;
            Instantiate(obstacle, new Vector3(x, y, z), Quaternion.identity);
            timer = 0f;
        }
    }
}