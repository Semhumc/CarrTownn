using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int coinCount = 0;
    public int winCondition = 15;
    public GameObject winPanel;

    public Text coinText;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void IncreaseCoinCount()
    {
        coinCount++;
        coinText.text = "Yıldız:" + coinCount.ToString();

        if (coinCount >= winCondition)
        {
            OpenWinPanel();
        }
    }

    private void OpenWinPanel()
    {
        winPanel.SetActive(true);
        
    }
}