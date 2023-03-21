using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    public int score;
    public int loadData;
    public Vector3 playerPos;
    public GameData()
    {
        this.score = 0;
        this.playerPos = new Vector3(0, 0, 0);
    }

}
