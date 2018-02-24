using UnityEngine;
using UnityEngine.Networking;

public class NetworkPlayerController : NetworkBehaviour {

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
