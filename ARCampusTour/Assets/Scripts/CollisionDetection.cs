using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    GameObject player;
    GameObject[] landmarks;
    Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;

        //get all locations
		landmarks = GameObject.FindGameObjectsWithTag("Landmark");
        //get canvas
        canvas = GameObject.FindObjectOfType<Canvas>();

        for (int i = 0; i < landmarks.Length; i++)
        {
            Debug.Log("Landmark " + i + " is named " + landmarks[i].name);
        } 
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerPos = player.GetComponent<GpsTracking>().GetPosition();
        //Check collide with all buildings!
        for (int i=0; i<landmarks.Length; i++)
        {
            CollidingObjectsAABB((GameObject)landmarks[i], playerPos);
            if(landmarks[i].name == "Apartment")
            {
                landmarks[i].GetComponent<LandmarkBlerb>().UpdateShortBlurb();
                landmarks[i].GetComponent<LandmarkBlerb>().UpdateLongBlurb();
            }
        }
    }



    // Rather than storing 2 GameObjects as variables, they'll be passed in as arguments
    bool CollidingObjectsAABB(GameObject a1, Vector3 playerPos)
    {
        // Algorithm:  
        // 1. Get the coordinates of both A and B
        // 2. Compare their left, right, top and bottom edges
        // 3. If colliding, return true
        BuildingBoundary a = a1.GetComponent<BuildingBoundary>();
        // Get left and right edges of first sprite
        float aMinX = a.GetXMin();
        float aMaxX = a.GetXMax();

        // Get top and bottom edges of first sprite
        float aMinZ = a.GetZMin();
        float aMaxZ = a.GetZMax();

        // Get left and right edges of second sprite
        float bX = playerPos.x;
        float bZ = playerPos.z;


        // Check for a collision!
        if (aMinX < bX && bX < aMaxX)
        {
            if (aMinZ < bZ && bZ < aMaxZ)
            {
                //Debug.Log("Collided with " + a1.name);
                //a1.GetComponent<LandmarkBlerb>().UpdateLongBlurb();
                //a1.GetComponent<LandmarkBlerb>().UpdateShortBlurb();

                return true;
            }
        }

        return false;
    }
    
}
