using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour {

	public GameObject pauseBtn;
	public GameObject pausePanel;
	public GameObject gameOverPanel;
	public GameObject coinPanelTxt;
	public GameObject gameOverCoinTxt;
	private bool isPause = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        pauseBtn.SetActive(false);
    }

	public void PausePlay(){
		if(isPause){
			isPause = false;
			Time.timeScale = 1;
			pauseBtn.SetActive(true);
			pausePanel.SetActive(false);
		}
		else{
			isPause = true;
			Time.timeScale = 0;
			pauseBtn.SetActive(false);
			pausePanel.SetActive(true);
		}
	}

	public void Restart(){
		Time.timeScale = 1;
		SceneManager.LoadScene("SampleScene");
	}
}
