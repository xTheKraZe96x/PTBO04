// using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GridCheck : MonoBehaviour {

	public List<GameObject> m_gridList = new List<GameObject>();
	public List<GameObject> m_shipTileList = new List<GameObject>();

	void Start(){
		// m_gridList = new List<GameObject>();
	}

	void Update(){
		CheckGrid();
	}

	public void CheckGrid(){
		foreach(GameObject check in m_gridList){
			TileShipCheck tmpCheck = check.GetComponent<TileShipCheck>();
			if(tmpCheck.m_isOccupied && !tmpCheck.m_broadcasted){
				// if(!tmpCheck.m_broadcasted)
				Debug.Log("Grid Position " + check.name + " Occupied!");
				tmpCheck.m_broadcasted = true;
			} else if(!tmpCheck.m_isOccupied && tmpCheck.m_broadcasted){
				tmpCheck.m_broadcasted = false;
				Debug.Log("Grid Position " + check.name + " Vacated!");
			}
		}
	}

	public void ListShipTiles(){
		string shipGrid = "";
		foreach(GameObject check in m_gridList){
			TileShipCheck tmpCheck = check.GetComponent<TileShipCheck>();
			if(tmpCheck.m_isOccupied){
				// if(!tmpCheck.m_broadcasted)
				shipGrid += "Grid Position " + check.name + " Occupied!\n";
				// Debug.Log("Grid Position " + check.name + " Occupied!\n");
				// tmpCheck.m_broadcasted = true;
				m_shipTileList.Add(check);
			} 
		}

		Debug.Log(shipGrid);
	}

	public void ListShipGrid(){
		int tileCount = 0;
		string gridLayout = "";
		foreach(GameObject check in m_gridList){
			TileShipCheck tmpCheck = check.GetComponent<TileShipCheck>();

			switch(tileCount){
				case 9:
					if(tmpCheck.m_isOccupied){
						gridLayout += tmpCheck.name + ": Y\n";
					} else {
						gridLayout += tmpCheck.name + ": N\n";
					}
					tileCount = 0;
				break;

				default:
					if(tmpCheck.m_isOccupied){
						gridLayout += tmpCheck.name + ": Y, ";
					} else {
						gridLayout += tmpCheck.name + ": N, ";
					}
					tileCount++;
				break;
			}
			// if(tileCount < 10){
			// 	if(tmpCheck.m_isOccupied){
			// 		gridLayout += tmpCheck.name + ": Y, ";
			// 	} else {
			// 		gridLayout += tmpCheck.name + ": N, ";
			// 	}
			// 	tileCount++;
			// }else 

			// if(tileCount == 10){
			// 	if(tmpCheck.m_isOccupied){
			// 		gridLayout += tmpCheck.name + ": Y.\n";
			// 	} else {
			// 		gridLayout += tmpCheck.name + ": N.\n";
			// 	}
			// 	tileCount = 0;
			// }
		}

		Debug.Log(gridLayout);
	}
}
