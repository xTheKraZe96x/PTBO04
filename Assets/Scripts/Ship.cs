using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

	public Rigidbody m_rgb;
	public bool m_onTile;
	private int m_health;
	private int m_size;
	private bool m_isSelected;
	// public GridCheck m_gridCheck;
	RaycastHit m_shipHit;
	public Ship m_shipScript;
	public Collider m_collider;
		

	// Use this for initialization
	void Start () {
		m_collider = GetComponent<BoxCollider>();
		m_shipScript = this.GetComponent<Ship>();
		m_onTile = false;
		// m_gridCheck = GameObject.FindObjectOfType<GridCheck>();
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
			Ray m_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(m_collider.Raycast(m_ray, out m_shipHit, 100.0f)) {
				m_isSelected = true;
				Debug.Log("Selected = " + this.m_isSelected);
			}
		} else if (Input.GetMouseButtonDown(0) && m_isSelected) {
			m_isSelected = false;
			this.transform.position = new Vector3(Mathf.RoundToInt(this.transform.position.x), Mathf.RoundToInt(this.transform.position.y), 0);
			Debug.Log("Selected = " + this.m_isSelected);
			// m_gridCheck.CheckGrid();
			
		} 

		//Movement with mouse
		//If the ship has been picked up
		if(m_isSelected){
			Vector3 tmpMouse = Input.mousePosition;
			tmpMouse.z = 7.5f;
			this.transform.position = Camera.main.ScreenToWorldPoint(tmpMouse);
			//Rotate the ship if it has been picked up
			if(Input.GetMouseButtonDown(1) && this.m_isSelected){
				Debug.Log("Rotation");
				this.transform.Rotate(0, 90, 0);
			}
		}	 
	}
}
