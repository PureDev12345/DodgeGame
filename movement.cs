using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    public CharacterController controller;
    public Transform player;
    public float speed = 12f;//players speed, adjust if u like.

    public LayerMask obstacle;//layer mask obstacle.
    bool istouching;

    void Update()
    {
        istouching = Physics.CheckSphere(player.position, 2f, obstacle);//creates a sphere with diameter of 2, if the obstacle layer toches, this bool is true.

        if (istouching )
        {
            print("touching");
            Application.Quit();//if this is true then the game ends, if u want u can add a score variable.
        }

        float x = Input.GetAxis("Horizontal");

        Vector3 move = transform.right * x;
        controller.Move(move * speed * Time.deltaTime);
    }
}
