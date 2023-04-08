using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collision_distroy : MonoBehaviour
{

    [SerializeField] string triggeringTag;
    [SerializeField]
    public int life = 3;
    [SerializeField]
    float respawn_time = 1f;
    [SerializeField]
    Vector3 start_position = new Vector3();
    [SerializeField]
    string lose_screen_name;



    IEnumerator respawn()
    {
        gameObject.GetComponent<costume_controller>().enabled = false;
        yield return new WaitForSeconds(respawn_time);
        gameObject.GetComponent<costume_controller>().enabled = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy" && enabled)
        {
            life--;
            if (life > 0)
            {
                try
                {
                    gameObject.GetComponent<points_handler>().life_to_text(life);
                    transform.position = start_position;
                    StartCoroutine(respawn());
                }
                catch
                { }
            }
            else
            {
                SceneManager.LoadScene(lose_screen_name);
            }
        }
    }
}
