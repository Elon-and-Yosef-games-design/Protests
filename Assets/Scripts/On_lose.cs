using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_lose : MonoBehaviour
{
    [SerializeField]
    int life = 3;
    [SerializeField]
    Vector3 start_position = new Vector3();
    [SerializeField]
    GameObject player_prefab;

    private void OnDisable()
    {
        if(life > 0)
        {
            GameObject camera = player_prefab.GetComponent<camera_follower>().camera_to_follow;//to keep the pointer to the camera
            GameObject newObject = Instantiate(player_prefab.gameObject, start_position, Quaternion.identity);//awake the player again
            player_prefab.GetComponent<On_lose>().life = life - 1;
            newObject.GetComponent<camera_follower>().camera_to_follow = camera;
            //foreach (GameObject myObject in player_prefab.GetComponents()) 
            //{ MyScript myScript = myObject.GetComponent<MyScript>(); myScript.enabled = true; }

        }
        else
        {
            Debug.Log("move to the next screen");
        }
    }
}
