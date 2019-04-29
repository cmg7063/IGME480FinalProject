using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDirection : MonoBehaviour
{
    GameObject player;
    Vector3 playerLoc;
    GameObject arrow;
    Vector3 target;
    Vector3 northVector;

    public float angleToTrack;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        arrow = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            return;
        }
        print("Current Target " + target.x + " " + target.z);
        playerLoc = player.GetComponent<GpsTracking>().GetPosition();
        northVector = new Vector3(0, 0, 0);
        // Get the location of the point to make up northVector
        if (target.x > playerLoc.x)
            northVector.x += 1;
        else
            northVector.x -= 1;

        Vector3 locationVector = target - playerLoc;

        // Get the angle between northVec and vector created by player location and target location
        angleToTrack = Mathf.Acos(Vector3.Dot(northVector, locationVector) /
            (Mathf.Sqrt((locationVector.x * locationVector.x) + (locationVector.z * locationVector.z))
           * Mathf.Sqrt((northVector.x * northVector.x) + (northVector.z * northVector.z))));

        print("The angle currently is " + angleToTrack);

        if (Input.location.status == LocationServiceStatus.Running)
            gameObject.transform.rotation = Quaternion.Euler(0, (angleToTrack + (-1)*player.GetComponent<GpsTracking>().GetDirection()), 0);
    }

    public void UpdateTarget(Vector3 newTarget)
    {
        target = newTarget;
    }
}
