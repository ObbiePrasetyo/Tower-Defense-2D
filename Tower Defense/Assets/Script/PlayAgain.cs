﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    private void Update()
{
    if (Input.GetMouseButtonDown(0))
    {
        // reload
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
}
