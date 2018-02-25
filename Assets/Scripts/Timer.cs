using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public static float m_timer = 60.0f;

	public Text m_text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		m_timer -= Time.deltaTime;
		Debug.Log(m_timer);
		m_text.text = Mathf.RoundToInt(m_timer).ToString();
	}
}
