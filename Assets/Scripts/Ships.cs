using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ships : MonoBehaviour {

	[SerializeField] private ShipTypes m_shipType;
	[SerializeField] private GameObject[] m_shipPool;
	[SerializeField] private GameObject m_shipMesh;
	[SerializeField] private int m_hitsAllowed;
	[SerializeField] private bool m_isDestroyed = true;


	enum ShipTypes {

		NONE = 0,
		SMALL,
		MEDIUM,
		LARGE,
		XLARGE
	}

	// Use this for initialization
	void Start () {
		switch(m_shipType){

			case ShipTypes.SMALL:
				m_hitsAllowed = 2;
			break;

			case ShipTypes.MEDIUM:
				m_hitsAllowed = 3;
			break;

			case ShipTypes.LARGE:
				m_hitsAllowed = 4;
			break;

			case ShipTypes.XLARGE:
				m_hitsAllowed = 5;
			break;

			case ShipTypes.NONE:
				Debug.Log("No ShipType Selected!");
			break;

			
		}
		m_isDestroyed = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
