using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MKToggleBool : ScriptableObject
{
   public bool enabled;

    public bool IsEnabled()
    {
        return enabled;
    }
}
