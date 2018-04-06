﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	public void LoadFirstLevel ()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
	}

    public void ExitGame()
    {
        Application.Quit();
    }
	
	
}
