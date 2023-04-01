using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_distroy : MonoBehaviour
{

    [SerializeField] string triggeringTag;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Destroy(this.gameObject);
        }
    }
}
