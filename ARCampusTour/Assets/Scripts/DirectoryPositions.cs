using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectoryPositions : MonoBehaviour
{
    public GameObject menuButton;

    Dictionary<string, Vector3> buildingLocations;

    // Start is called before the first frame update
    void Start()
    {
        buildingLocations = new Dictionary<string, Vector3>();
        buildingLocations.Add("LBJ", new Vector3(43.086852852904045f, 0, -77.66826874011144f));
        buildingLocations.Add("Ellingson", new Vector3(43.086292614003064f, 0f, -77.66803807013616f));
        buildingLocations.Add("CSD", new Vector3(43.086406229299264f,  0f, -77.66888028376684f));
        buildingLocations.Add("Sol",  new Vector3(43.08544677461002f,  -77.66719077795915f));
        buildingLocations.Add("NRH",  new Vector3(43.08492438120909f,  -77.66767524114499f));
        buildingLocations.Add("Gleason (Res)", new Vector3(43.08436503113918f,  -77.668249850535f));
        buildingLocations.Add("Gracies",  new Vector3(43.08380024762514f,  -77.66915126114623f));
        buildingLocations.Add("Greek Lawn ",   new Vector3(43.08507554116256f,  -77.67033237735848f));
        buildingLocations.Add("HAC",  new Vector3(43.08438380168817f,  -77.6722224107865f));
        buildingLocations.Add("August Center",   new Vector3(43.08422708570586f,  -77.67221436415946f));
        buildingLocations.Add("Camppus Center",   new Vector3(43.08394097596165f,  -77.67391965892347f));
        buildingLocations.Add("SAU",  new Vector3(43.084115323281125f,  -77.67454729583295f));
        buildingLocations.Add("Eastman",  new Vector3(43.0846367301761f,  -77.67527160116845f));
        buildingLocations.Add("Tiger",  new Vector3(43.08419890617654f,  -77.67554193735123f));
        buildingLocations.Add("Gannet",  new Vector3(43.08509190627381f,  -77.67631131842143f));
        buildingLocations.Add("Booth",  new Vector3(43.085187893505456f,  -77.67694700195796f));
        buildingLocations.Add("Wallace",  new Vector3(43.084147712618446f,  -77.67643826235553f));
        buildingLocations.Add("COLA",  new Vector3(43.08434948463289f,  -77.67642485131046f));
        buildingLocations.Add("Polisseni",  new Vector3(43.08292602418808f,  -77.67487338762209f));
        buildingLocations.Add("Gleason",   new Vector3(43.08317217429462f,  -77.67591405974639f));
        buildingLocations.Add("Gosnell",  new Vector3(43.08375124451561f,  -77.6774274491259f));
        buildingLocations.Add("Lowenthall",  new Vector3(43.08303229922444f,  -77.67715922822441f));
        buildingLocations.Add("Gleason Engineering",   new Vector3(43.08420262168506f,  -77.67758484734003f));
        buildingLocations.Add("Engineering Hall",   new Vector3(43.084298610310135f,  -77.67899032486383f));
        buildingLocations.Add("Golisano",  new Vector3(43.084448456688264f,  -77.6798144246062f));
        buildingLocations.Add("Orange",  new Vector3(43.083655586145234f,  -77.67885823321234f));
        buildingLocations.Add("USC",  new Vector3(43.08318500164543f,  -77.6798027676416f));
        buildingLocations.Add("Ross",  new Vector3(43.0825141991628f,  -77.67786095898623f));
        buildingLocations.Add("Global Village",   new Vector3(43.08287269640527f,  -77.68020858264413f));

        int yPos = buildingLocations.Count * 100 / 2 - 50;
        foreach (var building in buildingLocations) {
            var button = Instantiate(menuButton, new Vector3(0, yPos, 0), Quaternion.identity);
            button.GetComponentInChildren<Text>().text = building.Key;
            button.transform.SetParent(gameObject.transform, false);
            yPos -= 100;
        }

        RectTransform rt = gameObject.GetComponent(typeof(RectTransform)) as RectTransform;
        rt.sizeDelta = new Vector2(600, buildingLocations.Count * 100);
        rt.localPosition = new Vector3(0, -(buildingLocations.Count * 100 / 2), 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
