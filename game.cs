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

        if (timer >= 1f)//this tells in how many seconds the cube will spawn, rn its 1 sec, adjust as u like.
        {
            x = Random.Range(-5.99f, 6.6805f);//This is tha max and min values, add them accordingly to how much u want the cube to be max on left or right.
            y = 1.7047f;//This is how high the cube will spawn.
            z = 44.98f;//distance of cube from player.
            Instantiate(obstacle, new Vector3(x, y, z), Quaternion.identity);
            timer = 0f;
        }
    }
}
