﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character_Controller_Keyboard : MonoBehaviour
{
    private float speed = 10f;
    public int distanceOfRaycast=10;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()


    {
        PlayerMovement();

    }

    void PlayerMovement()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 velocity = direction * speed;
       
        velocity = Camera.main.transform.TransformDirection(velocity);
        controller.Move(velocity * Time.deltaTime);
    }
}