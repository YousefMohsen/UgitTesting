﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void LoadStage()  {


		SceneManager.LoadScene ("GameScene");
	}

}
