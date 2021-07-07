using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character_Controller_Keyboard : MonoBehaviour
{
    private float speed = 10f;
    public int distanceOfRaycast=10;
    public GameObject _Object;
    protected Vector3 rotation;

    MoveCube obj;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()


    {
        PlayerMovement();
        if (_Object.activeInHierarchy && Input.GetButtonUp("Fire1")) 
        {
           
            _Object.SetActive(false);
            _Object.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 4;
            _Object.transform.rotation = Camera.main.transform.rotation;
        }
        else if (!_Object.activeInHierarchy && Input.GetButtonUp("Fire1")) 
        {
            _Object.SetActive(true);
            _Object.transform.position = Camera.main.transform.position+Camera.main.transform.forward * 4;
            _Object.transform.rotation = Camera.main.transform.rotation; 
        }

    }

    void PlayerMovement()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 velocity = direction * speed;
        this.rotation = new Vector3(0, Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0);


        velocity = Camera.main.transform.TransformDirection(velocity);
        controller.Move(velocity * Time.deltaTime);
        this.transform.Rotate(this.rotation);

    }
}