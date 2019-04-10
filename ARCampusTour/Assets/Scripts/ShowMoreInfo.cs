using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMoreInfo : MonoBehaviour
{
    private GameObject longBlurbDesc;
    private GameObject shortBlurbDesc;
    public Text showMore;

    private int x;

    // Start is called before the first frame update
    void Start()
    {
        longBlurbDesc = GameObject.FindGameObjectWithTag("longBlurb");
        shortBlurbDesc = GameObject.FindGameObjectWithTag("shortBlurb");

        longBlurbDesc.SetActive(false);

        x = 0;
    }

    void OnEnable()
    {
        Lean.Touch.LeanTouch.OnFingerTap += OnFingerTap;
    }

    void OnDisable()
    {
        Lean.Touch.LeanTouch.OnFingerTap -= OnFingerTap;
    }

    void OnFingerTap(Lean.Touch.LeanFinger finger)
    {
        Debug.Log("You just tapped the screen with finger " + finger.Index + " at " + finger.ScreenPosition);

        if (x == 0)
        {
            longBlurbDesc.SetActive(true);
            shortBlurbDesc.SetActive(false);
            showMore.text = "Show Less";
            x = 1;
        }
        else
        {
            longBlurbDesc.SetActive(false);
            shortBlurbDesc.SetActive(true);
            showMore.text = "Show More";
            x = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
