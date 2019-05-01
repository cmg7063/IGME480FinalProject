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

    // Sound stuff
    public AudioClip clickSound;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        // Get the audio source
        source = GameObject.FindGameObjectWithTag("eventSystem").GetComponent<AudioSource>();
    }

    public void StartTour()
    {
        source.PlayOneShot(clickSound, 0.5f);
        SceneManager.LoadScene("LocationBlurb");
    }

    public void Directory()
    {
        source.PlayOneShot(clickSound, 0.5f);
        SceneManager.LoadScene("DirectoryList");
    }

    public void About()
    {
        source.PlayOneShot(clickSound, 0.5f);
        SceneManager.LoadScene("About");
    }

    public void Credits()
    {
        source.PlayOneShot(clickSound, 0.5f);
        SceneManager.LoadScene("Credits");
    }

    public void Menu()
    {
        source.PlayOneShot(clickSound, 0.5f);
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        source.PlayOneShot(clickSound, 0.5f);
        Application.Quit();
    }
}
