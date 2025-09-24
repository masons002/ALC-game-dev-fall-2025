using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
          UpdateScoreText();
    }
    
    public void IncreaseScoreText(int amount)
    {
         score += amount; //increase score by amount
         UpdateScoreText();    
    }
    
    public void DecreaseScoreText(int amount)
    {
         score-= amount; //Decrease score by amount
         UpdateScoreText();  

         
    }
    
    public void UpdateScoreText()
     {
          scoreText.text = "Score: " + score;
     }
    
}