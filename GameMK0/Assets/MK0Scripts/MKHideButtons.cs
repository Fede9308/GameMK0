using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MKHideButtons : MonoBehaviour
{
    [SerializeField] private GameObject[] Buttons;
    private bool ishidden=false;

    private void Start()
    {
        foreach (var button in Buttons)
        {
            button.gameObject.SetActive(false);
        }
        ishidden = true;
    }
    public void HideButtons()
    {
        if (!ishidden ) 
        {
            foreach (var button in Buttons)
            {
                button.gameObject.SetActive(false);
                
            }
            ishidden = true;
        }
        else 
        {
            foreach (var button in Buttons)
            {
                button.gameObject.SetActive(true);
            }
            ishidden = false;
        }
     
    }
}
