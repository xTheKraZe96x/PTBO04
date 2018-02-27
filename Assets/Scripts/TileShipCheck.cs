using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileShipCheck : MonoBehaviour {
	
	public bool m_isOccupied;
	public bool m_broadcasted;

	void Start(){
		m_isOccupied = false;
		m_broadcasted = false;
	}

	void OnTriggerStay(Collider other){
		if(other.tag == "Ship"){
			m_isOccupied = true;
			other.GetComponent<Ship>().m_onTile = true;
		}
	}

	void OnTriggerExit(Collider other){
		if(other.tag == "Ship"){
			m_isOccupied = false;
			other.GetComponent<Ship>().m_onTile = false;
		}
	}
}
