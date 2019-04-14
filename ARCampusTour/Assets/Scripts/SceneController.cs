using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public Button startTour;
    public Button directory;
    public Button about;
    public Button credits;
    public Button quit;
    public Button menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartTour()
    {
        SceneManager.LoadScene("LocationBlurb");
    }

    public void Directory()
    {
        SceneManager.LoadScene("DirectoryList");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
