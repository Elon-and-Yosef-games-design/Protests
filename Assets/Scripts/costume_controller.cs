using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class costume_controller : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;

    [SerializeField]
    float top_boudery = 14.27f;
    [SerializeField]
    float bottom_boudery = -7.43f;
    [SerializeField]
    float right_boudery = 15.01f;
    [SerializeField]
    float left_boudery = -9.83f;

    [SerializeField]
    InputAction up = new InputAction();
    [SerializeField]
    InputAction down = new InputAction();
    [SerializeField]
    InputAction right = new InputAction();
    [SerializeField]
    InputAction left = new InputAction();


    void OnEnable()
    {
        right.Enable();
        left.Enable();
        up.Enable();
        down.Enable();
    }

    void OnDisable()
    {
        right.Disable();
        left.Disable();
        up.Disable();
        down.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= right_boudery && right.IsPressed())
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (transform.position.x >= left_boudery && left.IsPressed())
        {
            transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
        }
        if (transform.position.y >= bottom_boudery && down.IsPressed())
        {
            transform.position += new Vector3(0, -1 * speed * Time.deltaTime, 0);
        }
        if (transform.position.y <= top_boudery && up.IsPressed())
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
    }
}
