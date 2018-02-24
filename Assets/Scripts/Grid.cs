using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {
	
	private int m_rows = 10;
	private int my_cols = 10;

	public Sprite m_sprite;

	public Transform m_gridContainer;

	public GameObject m_waterTile;


	

	// Use this for initialization
	void Start () {
	SpriteRenderer m_renderer = m_waterTile.AddComponent<SpriteRenderer>();
	m_renderer.sprite = m_sprite;
		for(int i = 0; i < 10; i++){
			for(int j = 0; j < 10; j++){
				GameObject tmpTile = Instantiate(m_waterTile, new Vector3(i, j, 0),Quaternion.identity);
				Debug.Log("Row " + i + "Column " + j );
				tmpTile.name = "Water Tile";
				tmpTile.transform.parent = m_gridContainer.transform;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
