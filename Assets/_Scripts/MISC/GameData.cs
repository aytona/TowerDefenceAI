﻿// Script to set all relevant data for game

public class GameData : Singleton<GameData> {
    private int score = 0;
    private int coins = 0;
    private int waveCount = 0;
    private int health = 100;

    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    public int Coins
    {
        get { return coins; }
        set { coins = value; }
    }

    public int WaveCount
    {
        get { return waveCount; }
        set { waveCount = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }
}