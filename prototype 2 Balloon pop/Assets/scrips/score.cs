using UnityEngine;
using System.Collection.Generic;
using sytem.Collection;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public int score;
    public textmeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreText();
    }
    
    public void IncreaseScoreText(int amount)
    {
         score += amount; //increase score by amount
         UpdateScoretext();    
    }
    
    public void DecreaseScoreText(int amount)
    {
         score-= amount; //Decrease score by amount
         UpdateScoretext();  

         
    }
    
    public void UpdateScoretex();
         {
            scoreText.text = "Score: " + score;
         }
    
}