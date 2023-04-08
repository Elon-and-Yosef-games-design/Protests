using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class points_handler : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI life_points_text;

    int life_points;
    // Start is called before the first frame update
    void Start()
    {
        life_points = gameObject.GetComponent<collision_distroy>().life;
    }

    public void life_to_text(int life)
    {
        life_points_text.text = life.ToString();
    }


    
}
