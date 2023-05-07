using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MKFinish : MonoBehaviour
{
    private AudioSource finishSound;

    private bool levelFinished = false; 
    void Start()
    {
       finishSound = GetComponent<AudioSource>(); 
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "MK0Player" && !levelFinished)
        {
            finishSound.Play();
            levelFinished = true;
            Invoke("CompleteLevel", 2f);
            
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
