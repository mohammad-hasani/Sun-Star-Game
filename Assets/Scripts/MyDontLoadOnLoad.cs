﻿using UnityEngine;
using System.Collections;

public class MyDontLoadOnLoad : MonoBehaviour {

	// Use this for initialization
	void Awake(){
        DontDestroyOnLoad(this.gameObject);
	}
	
}