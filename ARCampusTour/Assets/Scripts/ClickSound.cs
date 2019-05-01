using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    // Sound stuff
    public AudioClip clickSound;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        // Get the audio source
        source = GameObject.FindGameObjectWithTag("eventSystem").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound()
    {
        // Play the click sound
        source.Play();
    }
}
