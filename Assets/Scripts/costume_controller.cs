using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class costume_controller : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;

    [SerializeField]
    InputAction updown = new InputAction();

    [SerializeField]
    InputAction rightleft = new InputAction();


    void OnEnable()
    {
        rightleft.Enable();
        updown.Enable();
    }

    void OnDisable()
    {
        rightleft.Disable();
        updown.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = rightleft.ReadValue<float>();
        float vertical = updown.ReadValue<float>();

        Vector3 movementVector = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
        transform.position += movementVector;



        

    }
}
