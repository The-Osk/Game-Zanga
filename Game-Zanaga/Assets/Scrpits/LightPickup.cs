using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPickup : MonoBehaviour
{
    [SerializeField] float lightValue = 1f;
    [SerializeField] AudioClip batterySFX;
    void OnTriggerEnter2D(Collider2D collider)
    {
        FindObjectOfType<PlayerLight>().AddLight(lightValue);
        AudioSource.PlayClipAtPoint(batterySFX, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
