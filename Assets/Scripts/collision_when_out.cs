using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_when_out : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Destroy(this.gameObject);
        }
    }
}
