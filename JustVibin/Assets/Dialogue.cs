using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue
{
    public string girlPart;
    public string playerGood, playerNeutral, playerBad;

   public Dialogue(string girlPart, string playerGood, string playerNeutral, string playerBad) 
    {
        this.girlPart = girlPart;
        this.playerGood = playerGood;
        this.playerNeutral = playerNeutral;
        this.playerBad = playerBad;
    }

    public string GetGood()
    {
        return playerGood;
    }
    public string GetNeutral()
    {
        return playerNeutral;
    }
    public string GetBad()
    {
        return playerBad;
    }
}
