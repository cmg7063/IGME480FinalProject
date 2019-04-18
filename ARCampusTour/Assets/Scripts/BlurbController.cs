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

    private Vector2 visiblePos = new Vector2(21.0f, -5.0f);
    private Vector2 notVisiblePos = new Vector2(-2000.0f, -2000.0f);


    // Start is called before the first frame update
    void Start()
    {
        longBlurbDesc = GameObject.FindGameObjectWithTag("longBlurb");
        shortBlurbDesc = GameObject.FindGameObjectWithTag("shortBlurb");
        blurbBlock = GameObject.FindGameObjectWithTag("blurbBlock");
        //longBlurbDesc.SetActive(false);

        x = 0;
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
        blurbBlock.SetActive(false);
    }

    public void ShowBlock()
    {
        blurbBlock.SetActive(true);
        x = 1;
        ShowMore();
    }
}
