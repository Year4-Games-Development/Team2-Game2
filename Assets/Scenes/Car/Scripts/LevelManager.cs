﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//script for manin menu buttons

public class LevelManager : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(1);

    }

    public void QuitGame()
    {
        Application.Quit();

    }
}
