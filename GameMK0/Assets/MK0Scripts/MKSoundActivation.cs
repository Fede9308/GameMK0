using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class MKSoundActivation : MonoBehaviour
{
   [SerializeField]  GameObject audioSourceObject;  
    private AudioSource audioSource;
    private bool isAudioOn;

    private void Start()
    {
        audioSource = audioSourceObject.GetComponent<AudioSource>();
        isAudioOn = PlayerPrefs.GetInt("IsAudioOn", 1) == 1;  
        audioSource.gameObject.SetActive(isAudioOn);
    }

    public void ToggleAudio()
    {
        isAudioOn = !isAudioOn;
        audioSource.gameObject.SetActive(isAudioOn);
        PlayerPrefs.SetInt("IsAudioOn", isAudioOn ? 1 : 0);
        EventSystem.current.SetSelectedGameObject(null);
    }
}
