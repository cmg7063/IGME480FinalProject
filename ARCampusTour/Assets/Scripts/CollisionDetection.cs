using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    GameObject player;
    GameObject[] landmarks;
    public Canvas canvas;
    public GameObject testLandmark;
    GameObject lastCollided;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
        lastCollided = gameObject;

        //get all locations
		landmarks = GameObject.FindGameObjectsWithTag("Landmark");
    }

    // Update is called once per frame
    void Update()
    {
		
		print(landmarks);

        Vector3 playerPos = player.GetComponent<GpsTracking>().GetPosition();

        BuildingBoundary a = testLandmark.GetComponent<BuildingBoundary>();

        testLandmark.GetComponent<LandmarkBlerb>().UpdateLongBlurb("Lat: " + playerPos.x + " Long: " + playerPos.z + "Building lat min: "+ a.GetXMin() + "lat max: " + a.GetXMax() + "long min: " + a.GetZMin()+ "long max: " + a.GetZMax() + "Collided? "+ CollidingObjectsAABB(testLandmark, playerPos));
        testLandmark.GetComponent<LandmarkBlerb>().UpdateShortBlurb("Lat: " + playerPos.x + " Long: " + playerPos.z + "Building lat min: "+ a.GetXMin() + "lat max: " + a.GetXMax() + "long min: " + a.GetZMin()+ "long max: " + a.GetZMax() + "Collided? "+ CollidingObjectsAABB(testLandmark, playerPos));

        //Check collide with all buildings!
        /*
        for (int i=0; i<landmarks.Length; i++)
        {
            CollidingObjectsAABB((GameObject)landmarks[i], playerPos);
        } */
    }



    // Rather than storing 2 GameObjects as variables, they"ll be passed in as arguments
    bool CollidingObjectsAABB(GameObject a1, Vector3 playerPos)
    {
        if (lastCollided.name.Equals(a1.name)) return false;
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
                a1.GetComponent<LandmarkBlerb>().UpdateLongBlurb();
                a1.GetComponent<LandmarkBlerb>().UpdateShortBlurb();
                //show block!
                canvas.GetComponent<BlurbController>().ShowBlock();
                lastCollided = a1;
                return true;
            }
        }

        return false;
    }
    
}
