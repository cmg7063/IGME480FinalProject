using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDirection : MonoBehaviour
{
    GameObject player;
    GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        arrow = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.location.status == LocationServiceStatus.Running)
            gameObject.transform.rotation = Quaternion.Euler(0, player.GetComponent<GpsTracking>().GetDirection(), 0);
    }
}
