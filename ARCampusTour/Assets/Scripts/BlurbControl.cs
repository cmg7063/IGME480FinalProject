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

    private int x;

    // Start is called before the first frame update
    void Start()
    {
        longBlurbDesc = GameObject.FindGameObjectWithTag("longBlurb");
        shortBlurbDesc = GameObject.FindGameObjectWithTag("shortBlurb");
        blurbBlock = GameObject.FindGameObjectWithTag("blurbBlock");

        longBlurbDesc.SetActive(false);

        x = 0;
    }

    public void ShowMore()
    {
        if (x == 0)
        {
            longBlurbDesc.SetActive(true);
            shortBlurbDesc.SetActive(false);
            showMore.GetComponentInChildren<Text>().text = "Show Less";
            x = 1;
        }
        else
        {
            longBlurbDesc.SetActive(false);
            shortBlurbDesc.SetActive(true);
            showMore.GetComponentInChildren<Text>().text = "Show More";
            x = 0;
        }
    }

    public void CloseBlock()
    {
        blurbBlock.SetActive(false);
    }
}
