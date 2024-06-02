using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SundBoard : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;
    void Start()
    {
        UnityEngine.AudioClip audioClip = audioSource.clip;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        MediaPlayer();
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            audioSource.PlayOneShot(audioClip);
        }
    }

    private void MediaPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            audioSource.Stop();

        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            audioSource.Pause();
        }
    }
}