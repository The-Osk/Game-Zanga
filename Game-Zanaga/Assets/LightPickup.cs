using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPickup : MonoBehaviour
{
    [SerializeField] float lightValue = 1f;
    void OnTriggerEnter2D(Collider2D collider)
    {
        FindObjectOfType<PlayerLight>().AddLight(lightValue);
        Destroy(gameObject);
    }
}
