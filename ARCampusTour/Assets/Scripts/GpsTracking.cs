using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GpsTracking : MonoBehaviour
{
    // Postition on Earth (in kilometers)
    public float latitude;
    public float longitude;
    public float altitude;
    public bool updateLocation = true;

    public string shortBlurb;
    private GameObject shortBlurbDesc;


    IEnumerator StartUpdatingLocation()
    {
        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
            print("Throw Exception!, User does not have location enabled!");

        // Next, check if the user has the location query service already turned on
        if (Input.location.status == LocationServiceStatus.Running)
        {
            latitude = Input.location.lastData.latitude;
            longitude = Input.location.lastData.longitude;
            altitude = Input.location.lastData.altitude;

            shortBlurbDesc.GetComponent<Text>().text = "Latitude: " + latitude + "   Longitude: " + longitude + "   Altitude: " + altitude;
        }
        else
        {
            // Start service before querying location
            Input.location.Start();

            // Wait until service initializes
            int maxWait = 20;
            print("Getting Location Data");
            while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
            {
                yield return new WaitForSeconds(1);
                maxWait--;
            }

            // Service didn't initialize in 20 seconds
            if (maxWait < 1)
            {
                print("Timed out");
                yield break;
            }

            // Connection has failed
            if (Input.location.status == LocationServiceStatus.Failed)
            {
                print("Unable to determine device location");
                yield break;
            }
            else
            {
                // Access granted and location value could be retrieved
                print("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);
            }
        }
    }

        // Start is called before the first frame update
        void Start()
    {
        latitude = 0f;
        longitude = 0f;
        altitude = 0f;

        shortBlurbDesc = GameObject.FindGameObjectWithTag("shortBlurb");
    }

    void StopUpdatingLocation()
    {
        // Stop service if there is no need to query location updates continuously
        Input.location.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (updateLocation == false)
        {
            StopUpdatingLocation();
        }
        else
        {
            StartCoroutine(StartUpdatingLocation());
        }
    }

    public Vector3 GetPosition()
    {
        return new Vector3(latitude, altitude, longitude);
    }
}
