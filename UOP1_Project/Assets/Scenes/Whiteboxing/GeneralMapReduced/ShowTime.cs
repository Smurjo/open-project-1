﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Text text = gameObject.GetComponent<Text>();
		text.text = "Time: " + Time.timeSinceLevelLoad;
	}
}
