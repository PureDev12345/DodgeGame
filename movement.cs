using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    public CharacterController controller;
    public Transform player;
    public float speed = 12f;

    public LayerMask obstacle;
    bool istouching;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        istouching = Physics.CheckSphere(player.position, 2f, obstacle);

        if (istouching )
        {
            print("nigga");
            Application.Quit();
        }

        float x = Input.GetAxis("Horizontal");

        Vector3 move = transform.right * x;
        controller.Move(move * speed * Time.deltaTime);
    }
}
