using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

	private int m_shipsLeft = 5;
	
	void Start(){
		
	}

	void Update(){
		if (!isLocalPlayer)
		{
			return;
		}

	}

	public void ShipLost(){
		m_shipsLeft--;
	}
}
