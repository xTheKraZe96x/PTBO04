using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

	private Rigidbody m_rgb;
	private int m_health;
	private int m_size;
	private bool m_isSelected;

	GameObject m_gameObject;
	
	private Renderer m_rend;
	

	// Use this for initialization
	void Start () {
		m_rgb = GetComponent<Rigidbody>();
		m_rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {

	//Temporary Ship movement
	// 	if(Input.GetKeyDown(KeyCode.LeftArrow)){
	// 		m_rgb.MovePosition(m_rgb.position + Vector3.left);
	// 	}

	// 	if(Input.GetKeyDown(KeyCode.RightArrow)){
	// 		m_rgb.MovePosition(m_rgb.position + Vector3.right);
	// 	}

	// 	if(Input.GetKeyDown(KeyCode.UpArrow)){
	// 		m_rgb.MovePosition(m_rgb.position + Vector3.up);
	// 	}

	// 	if(Input.GetKeyDown(KeyCode.DownArrow)){
	// 		m_rgb.MovePosition(m_rgb.position + Vector3.down);
	// 	}
	// }

	if(Input.GetMouseButtonDown(0) && !m_isSelected){
		RaycastHit m_shipHit = new RaycastHit();
			if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out m_shipHit)){
				m_isSelected = true;
				Debug.Log(m_isSelected);
			}
		} else if (Input.GetMouseButtonDown(0) && m_isSelected) {
					m_isSelected = false;
					this.transform.position = transform.position;
					Debug.Log(m_isSelected);
			} 

	//Movement with mouse
	//If the ship has been picked up
		if(m_isSelected){
			Vector3 tmpMouse = Input.mousePosition;
			tmpMouse.z = 8f;
			this.transform.position = Camera.main.ScreenToWorldPoint(tmpMouse);
			//Rotate the ship if it has been picked up
				if(Input.GetMouseButtonDown(1) && m_isSelected){
					Debug.Log("Rotation");
					this.transform.Rotate(0, 90, 0);
			}
		}	 
	}
}
