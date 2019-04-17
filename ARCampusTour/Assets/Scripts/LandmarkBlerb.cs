using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LandmarkBlerb : MonoBehaviour
{
    public string shortBlurb = "There is no short blurb for this landmark";
    public string longBlurb = "There is no long blurb for this landmark";
    public string hyperlink;

    public GameObject longBlurbDesc;
    public GameObject shortBlurbDesc;

    // Start is called before the first frame update
    void Start()
    {
        longBlurbDesc = GameObject.FindGameObjectWithTag("longBlurb");
        shortBlurbDesc = GameObject.FindGameObjectWithTag("shortBlurb");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateShortBlurb()
    {
        shortBlurbDesc.GetComponent<Text>().text = shortBlurb;
    }
    public void UpdateLongBlurb()
    {
        longBlurbDesc.GetComponent<Text>().text = longBlurb;

    }
}
