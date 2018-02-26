using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileShipCheck : MonoBehaviour {
	
	public bool m_isOccupied;

	void Start(){
		m_isOccupied = false;
	}

	void OnTriggerStay(Collider other){
		if(other.tag == "Ship"){
			m_isOccupied = true;
		}
	}
}
