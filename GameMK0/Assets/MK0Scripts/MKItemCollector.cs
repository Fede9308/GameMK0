using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MKItemCollector : MonoBehaviour
{
    private int melons = 0;

    [SerializeField] private Text melonsText;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Melon"))
        {
            Destroy(collision.gameObject);
            melons++;
            melonsText.text = "Melons: " + melons;
        }
    }
}
