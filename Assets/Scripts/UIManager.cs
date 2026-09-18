using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] TextMeshProUGUI _xpText;
    [SerializeField] TextMeshProUGUI _coinsText;

    [Header("References")]
    [SerializeField] GameManager _gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    public void UpdateScore()
    {
        _scoreText.text = $"Score: {_gameManager.Score}";
    }

    public void UpdateXP()
    {
        _xpText.text = $"XP: {_gameManager.Xp}";
    }

    public void UpdateCoins()
    {
        _coinsText.text = $"Coins: {_gameManager.Coins}";
    }
}
