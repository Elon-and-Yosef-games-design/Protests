using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opening_scene : MonoBehaviour
{
    [SerializeField]
    Vector3 stop_position;
    [SerializeField]
    float velocity;
    [SerializeField] float time_to_wait;
    [SerializeField]
    Vector3 disapear_position;
    [SerializeField]
    GameObject player;

    float arive_flag = 0;
    float visited_corutin = 0;

    IEnumerator Rutin()
    {
        visited_corutin = 1;
        arive_flag = 1;
        yield return new WaitForSeconds(time_to_wait);
        player.SetActive(true);
        arive_flag = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        player.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x >= stop_position.x)
        {
            arive_flag = 0;
        }
        else if(visited_corutin == 0)
            StartCoroutine(Rutin());

        if(arive_flag == 0)
        {
            transform.position += new Vector3(-1 * velocity * Time.deltaTime, 0);
        }

    }
}
