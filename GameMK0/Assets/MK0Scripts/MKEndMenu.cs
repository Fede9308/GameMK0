using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MKEndMenu : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        EventSystem.current.SetSelectedGameObject(null);
    }
}
