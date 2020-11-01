using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] AudioClip doorSFX;
    void OnTriggerEnter2D(Collider2D playerCollide)
    {
        if (playerCollide.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(doorSFX, Camera.main.transform.position);
            StartCoroutine(DelayForSound());
            //FindObjectOfType<GameManger>().LoadNextLevel();
        }
    }

    IEnumerator DelayForSound()
    {
        yield return new WaitForSeconds(1.8f);
        FindObjectOfType<GameManger>().LoadNextLevel();
    }
}
