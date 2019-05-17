using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    // Déclare les object des bouton dans le menu
    public GameObject pauseBtn;
    public GameObject pausePanel;
    public GameObject gameOverPanel;
    public GameObject coinPanelTxt;
    public GameObject gameOverCoinTxt;
    private bool isPause = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // Fonction qui sert a faire apparaître le menu quand le joueur est touché par le monstre ou tombre dans un trou (arrête le jeux).
    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        GameObject.FindGameObjectWithTag("Score").GetComponent<CoinAmount>().Score();
        pauseBtn.SetActive(false);
    }

    // Sert a faire fonctionner le bouton pause play et donc a afficher le menu   
    public void PausePlay()
    {
        if (isPause)
        {
            isPause = false;
            Time.timeScale = 1;
            pauseBtn.SetActive(true);
            pausePanel.SetActive(false);
        }
        else
        {
            isPause = true;
            Time.timeScale = 0;
            pauseBtn.SetActive(false);
            pausePanel.SetActive(true);
        }
    }
    // Relance la scène du début
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
