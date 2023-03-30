using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*this sicript let the camera follow the palyer on one axie*/
public class camera_follower : MonoBehaviour
{

    [SerializeField]
    GameObject player_to_follow;

    [SerializeField]
    float offset = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float p_y_position = player_to_follow.transform.position.y;
        transform.position = new Vector3(transform.position.x, p_y_position + offset, -10);// -10 is for alignment z level of tile map
    }
}
