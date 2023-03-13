using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTalk : MonoBehaviour
{

    public AudioSource audioSource;
    public bool audioStarted;

    void Start()
    {


    }

    void Update()
    {
        if (audioStarted && !audioSource.isPlaying)
        {
            SceneManager.LoadScene("Title");
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (!audioStarted)
        {
            audioSource.Play();
            audioStarted = true;
        }
    }
    }
