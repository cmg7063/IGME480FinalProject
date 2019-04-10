using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    GameObject player;
    ArrayList landmarks;
    Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;

        //get all locations
        GameObject[] locationObjects = GameObject.FindGameObjectsWithTag("Landmark");
        for(int i=0; i< locationObjects.Length; i++)
        {
            landmarks.Add(locationObjects[i].GetComponent<BuildingBoundary>());
        }

        //get canvas
        canvas = GameObject.FindObjectOfType<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.GetComponent<GpsTracking>().GetPosition();
        //Check collide with all buildings!
        for (int i=0; i<landmarks.Count; i++)
        {
            CollidingObjectsAABB((BuildingBoundary)landmarks[i], playerPos);
        }
    }



    // Rather than storing 2 GameObjects as variables, they'll be passed in as arguments
    bool CollidingObjectsAABB(BuildingBoundary a, Vector3 playerPos)
    {
        // Algorithm:  
        // 1. Get the coordinates of both A and B
        // 2. Compare their left, right, top and bottom edges
        // 3. If colliding, return true

        // Get left and right edges of first sprite
        float aMinX = a.GetXMin();
        float aMaxX = a.GetXMax();

        // Get top and bottom edges of first sprite
        float aMinY = a.GetYMin();
        float aMaxY = a.GetYMax();

        // Get left and right edges of second sprite
        float bX = playerPos.x;
        float bY = playerPos.y;

        // Check for a collision!
        if (aMinX < bX && bX < aMaxX)
        {
            if (aMinY < bY && bY < aMaxY)
            {
                Debug.Log("Collision!");
                return true;
            }
        }

        return false;
    }
    
}
