using UnityEngine;

public class PlayerController : MonoBehaviour {

	private int m_shipsLeft = 5;
	
	void Start(){
		
	}

	void Update(){

	}

	public void ShipLost(){
		m_shipsLeft--;
	}
}
