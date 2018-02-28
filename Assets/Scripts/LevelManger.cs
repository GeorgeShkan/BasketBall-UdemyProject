using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour {
    // Use this for initialization
    public int score = 0;

    void Start () {
        //Load Scene
        DontDestroyOnLoad(gameObject);
        //print("Loading Game");
        //current index + 1    
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    public void incrementScore()
    {
        score++;
    }

    public int getScore()
    {
        return score;
    }

    public void NextSceneLevel()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void replayGame()
    {
        score = 0;
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex - 1);
        //timeRemaining = 20.0f;
        
    }
}
