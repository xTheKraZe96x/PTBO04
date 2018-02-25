using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSinglePlayer : MonoBehaviour {

	[SerializeField] Scene m_currentScene;
	[SerializeField] Scene m_startScene;
	[SerializeField] Scene m_gameScene;

	void Start(){
		m_startScene = SceneManager.GetSceneByName("StartScreen");
		m_gameScene = SceneManager.GetSceneByName("Shawn");

		m_currentScene = SceneManager.GetActiveScene();
	}

	public void RunSP(){
		Debug.Log("Load Single Player");
		// SceneManager.SetActiveScene(m_gameScene);
		SceneManager.LoadScene("Shawn", LoadSceneMode.Single);
		
	}
}
