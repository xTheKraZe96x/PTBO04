using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

	private Rigidbody m_rgb;

	private int m_health;
	private int m_size;

	private bool m_isSelected;
	

	// Use this for initialization
	void Start () {
		m_rgb = GetComponent<Rigidbody>();
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

	if(Input.GetMouseButtonDown(0)){
		RaycastHit m_shipHit = new RaycastHit();
		if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out m_shipHit)){
			Debug.Log("Fuck");
			m_isSelected = true;
		}
	}

	//Movement with mouse
		if(m_isSelected){
			Vector3 tmpMouse = Input.mousePosition;
			tmpMouse.z = 8f;
			this.transform.position = Camera.main.ScreenToWorldPoint(tmpMouse);
		}
	}
}
