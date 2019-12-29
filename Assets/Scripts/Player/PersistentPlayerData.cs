using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentPlayerData : MonoBehaviour
{
    private string playerId;
    private string playerName;
    private DateTime lastLogin;
    private DateTime currentLogin;
    private TimeSpan totalTimeOn;
    private int lives;
    private int currentLevel;
    private Dictionary<int, bool> playerProgress = new Dictionary<int, bool>();        //<Level (1-50), T/F>

    public PersistentPlayerData(string playerId, string playerName, DateTime lastLogin, DateTime currentLogin, TimeSpan totalTimeOn, int lives, int currentLevel)
    {
        this.playerId = playerId;
        this.playerName = playerName;
        this.lastLogin = lastLogin;
        this.currentLogin = currentLogin;
        this.totalTimeOn = totalTimeOn;
        this.lives = lives;
        this.currentLevel = currentLevel;
    }
}
