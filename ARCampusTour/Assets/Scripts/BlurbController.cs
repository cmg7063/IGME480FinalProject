using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlurbController : MonoBehaviour
{
    public Button showMore;
    public Button closeBlock;

    private GameObject longBlurbDesc;
    private GameObject shortBlurbDesc;
    private GameObject blurbBlock;
    private GameObject websiteBlock;

    private string link;
    private bool hasLink;

    private int x;

    private Vector2 visiblePos = new Vector2(21.0f, -5.0f);
    private Vector2 notVisiblePos = new Vector2(-2000.0f, -2000.0f);

    // Sound stuff
    public AudioClip closeSound;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        longBlurbDesc = GameObject.FindGameObjectWithTag("longBlurb");
        shortBlurbDesc = GameObject.FindGameObjectWithTag("shortBlurb");
        blurbBlock = GameObject.FindGameObjectWithTag("blurbBlock");
        websiteBlock = GameObject.FindGameObjectWithTag("websiteBlock");
        //longBlurbDesc.SetActive(false);

        x = 0;

        link = GameObject.FindGameObjectWithTag("Landmark").GetComponent<LandmarkBlerb>().GetLink();
        websiteBlock.GetComponentInChildren<Text>().text = "";

        // Get the audio source
        source = GetComponent<AudioSource>();

        // If the link variable in the LandmarkBlerb script is empty, this location does not have a website therefore do not show text for website
        if (string.IsNullOrEmpty(link))
        {
            hasLink = false;
            //websiteBlock.SetActive(false);
        }
    }

    public void ClickLink()
    {
        if(hasLink)
        {
            //websiteBlock.SetActive(true);
            websiteBlock.GetComponentInChildren<Text>().text = "Website";
            Application.OpenURL(link);
        }
    }

    public void ShowMore()
    {
        if (x == 0)
        {
            //longBlurbDesc.SetActive(true);
            longBlurbDesc.GetComponent<RectTransform>().anchoredPosition = visiblePos;
            shortBlurbDesc.GetComponent<RectTransform>().anchoredPosition = notVisiblePos;
            //shortBlurbDesc.SetActive(false);
            showMore.GetComponentInChildren<Text>().text = "Show Less";
            x = 1;
        }
        else
        {
            longBlurbDesc.GetComponent<RectTransform>().anchoredPosition = notVisiblePos;
            shortBlurbDesc.GetComponent<RectTransform>().anchoredPosition = visiblePos;
            //longBlurbDesc.SetActive(false);
            //shortBlurbDesc.SetActive(true);
            showMore.GetComponentInChildren<Text>().text = "Show More";
            x = 0;
        }
    }

    public void CloseBlock()
    {
        source.PlayOneShot(closeSound, 0.5f);
        blurbBlock.SetActive(false);
    }

    public void ShowBlock()
    {
        blurbBlock.SetActive(true);
        x = 1;
        ShowMore();
    }
}
