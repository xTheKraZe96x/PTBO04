using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCheck : MonoBehaviour {

	// public GameObject[] m_gridList;
	public List<GameObject> m_shipList;
	public GameObject m_shipListPrefab;

	public List<GameObject> m_gridList;

	void Start(){
		// m_shipList = new List<GameObject>();
		m_gridList = new List<GameObject>();
	}

	void Update(){
		
	}

	void CheckGrid(){
		foreach(GameObject check in m_gridList){
			if(check.GetComponent<TileShipCheck>().m_isOccupied){
				Debug.Log("Y");
			} 
			// else {
			// 	Debug.Log("N");
			// }
		}
	}
}
