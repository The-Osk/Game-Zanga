﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D playerCollide)
    {
        if(playerCollide.tag == "Player")
        SceneManager.LoadScene(1);
    }
}
