using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField]
    Vector3 direction = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetVelocity(Vector3 newVelocity)
    {
        this.direction = newVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime;
    }
}
