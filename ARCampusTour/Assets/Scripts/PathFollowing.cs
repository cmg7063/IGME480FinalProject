using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowing : MonoBehaviour
{
    public GameObject[] pathPoints;
    public int currIndex; //current target
    public float posMargin; //margin of error to switch to next target
    public bool isMoving; //set to false when blurb pops up, set to true when user closes blurb
    public float maxDistToPlayer; //max distance the guide can be from the player

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currPos = gameObject.transform.position;
        Vector3 goal = pathPoints[currIndex].GetComponent<PathPoint>().GetPosition();
        Vector3 nextPos = currPos;

        Vector3 direction = (goal - currPos).normalized;

        nextPos = currPos + maxDistToPlayer*direction;

        Quaternion nextRot = gameObject.transform.rotation;

        gameObject.transform.SetPositionAndRotation(nextPos, nextRot);


        if ((nextPos - pathPoints[currIndex].GetComponent<PathPoint>().GetPosition()).magnitude < posMargin)
        {
            currIndex++;
            if (currIndex >= pathPoints.Length)
            {
                //End the tour!!!!
                currIndex = 0;
            }
        }
        
    }
}
