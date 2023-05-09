using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MKRestart : MonoBehaviour
{
    public int scene;
    public void RestartGame()
    {
        SceneManager.LoadScene(scene);
    }
}
