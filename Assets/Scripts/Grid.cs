using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {
	
	private int m_rows = 10;
	private int my_cols = 10;
	private Vector3 m_gridStartPosition = new Vector3(2.0f, 0, 0);

	// public Sprite m_sprite;
	// public GameObject m_waterTile;
	public GameObject m_shipList;
	public GameObject m_player;
	public Transform m_gridContainer;
	public GameObject m_waterTilePrefab;
	public GridCheck m_gridCheck;


	void Start () {
		char tileLetter = ' ';
		int gridCount = 0;
		// SpriteRenderer m_renderer = m_waterTile.AddComponent<SpriteRenderer>();
		// m_renderer.sprite = m_sprite;
		for(int i = 9; i >= 0; i--){
			for(int j = 1; j < 11; j++){
				GameObject tmpTile = Instantiate(m_waterTilePrefab, new Vector3(j, i, 0),Quaternion.identity);
				
				// Debug.Log("Row " + i + "Column " + j );

				switch(i){
					case 9:
						tileLetter = 'A';
					break;

					case 8:
						tileLetter = 'B';
					break;

					case 7:
						tileLetter = 'C';
					break;

					case 6:
						tileLetter = 'D';
					break;

					case 5:
						tileLetter = 'E';
					break;

					case 4:
						tileLetter = 'F';
					break;

					case 3:
						tileLetter = 'G';
					break;

					case 2:
						tileLetter = 'H';
					break;

					case 1:
						tileLetter = 'I';
					break;

					case 0:
						tileLetter = 'J';
					break;
				}

				tmpTile.name = tileLetter + j.ToString();
				tmpTile.transform.parent = m_gridContainer.transform;
				m_gridCheck.m_gridList.Add(tmpTile);
				gridCount++;
			}
		}
		m_gridContainer.name = m_player.name + " Grid";
		m_gridContainer.transform.position = m_gridStartPosition;
		Instantiate(m_shipList);
		m_gridContainer.transform.parent = m_player.transform;
	}
	
	void Update () {
		
	}
}
