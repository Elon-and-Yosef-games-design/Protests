using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class On_win_collision : MonoBehaviour
{
    [SerializeField]
    string win_tag;
    [SerializeField]
    GameObject screen_handler;

    [SerializeField]
    float wait_time = 0.5f;


    IEnumerator wait_for_a_momnet()
    {
        yield return new WaitForSeconds(wait_time);
        screen_handler.GetComponent<screen_handler>().load_win_screen();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.tag == win_tag && enabled )
        {
            StartCoroutine(wait_for_a_momnet());
        }
    }
}
