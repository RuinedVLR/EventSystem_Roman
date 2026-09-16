using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] TextMeshProUGUI _xpText;
    [SerializeField] TextMeshProUGUI _coinsText;

    [Header("Player Stats")]
    [SerializeField] int _xp;
    [SerializeField] int _coins;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateXP(int xp)
    {
        _xp = xp;
        _xpText.text = $"XP: {_xp}";
    }

    void UpdateCoins(int coins)
    {
        _coins = coins;
        _coinsText.text = $"Coins: {_coins}";
    }
}
