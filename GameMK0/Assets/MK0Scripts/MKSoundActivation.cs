using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MKSoundActivation : MonoBehaviour
{
   [SerializeField]  GameObject audioSourceObject;  // Drag and drop the audio source object in the inspector
    private AudioSource audioSource;
    private bool isAudioOn;

    private void Start()
    {
        audioSource = audioSourceObject.GetComponent<AudioSource>();
        isAudioOn = PlayerPrefs.GetInt("IsAudioOn", 1) == 1;  // Load the audio state from player prefs
        audioSource.gameObject.SetActive(isAudioOn);
    }

    public void ToggleAudio()
    {
        isAudioOn = !isAudioOn;
        audioSource.gameObject.SetActive(isAudioOn);
        PlayerPrefs.SetInt("IsAudioOn", isAudioOn ? 1 : 0);  // Save the audio state to player prefs
    }
}
