using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    // Rather than storing 2 GameObjects as variables, they'll be passed in as arguments
    bool CollidingObjectsAABB(GameObject a)
    {
        // Algorithm:  
        // 1. Get the coordinates of both A and B
        // 2. Compare their left, right, top and bottom edges
        // 3. If colliding, return true

        // Get left and right edges of first sprite
        float aMinX = a.GetComponentInChildren<BuildingBoundary>().GetXMin();
        float aMaxX = a.GetComponentInChildren<BuildingBoundary>().GetXMax();

        // Get top and bottom edges of first sprite
        float aMinY = a.GetComponentInChildren<BuildingBoundary>().GetYMin();
        float aMaxY = a.GetComponentInChildren<BuildingBoundary>().GetYMax();

        // Get left and right edges of second sprite
        Vector3 playerPos = player.GetComponent<GpsTracking>().GetPosition();
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
