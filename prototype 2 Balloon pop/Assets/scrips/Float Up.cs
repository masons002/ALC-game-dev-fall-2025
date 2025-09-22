using UnityEngine;


public class floatUp : MonoBehaviour
{
    
    public float speed;
    public float upperBound = 15.0f;
    public ScorManager scorManager;// refercing the score mananger
    public Balloon ballon;// Referencing the balloon script to get the score

     // Start is called once before the first execution of Update after the MonoBehaviour is created
     void Start()
      {
            scoremanager = GameObject.find("ScoreManager"). GetComponent<ScoreManager>();
            ballon = GetComponent<Ballon>();
      }
  
        // Update is called once per frame 
       void Update()
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if(transfomr.position.y >= upperBound)
            {
                scoreManager.DecreaseScoreText(Balloon.scoreToGive); // Reduce score for allowing the balloon to leave the screen 
                Destroy(gameOject); // Pop balloon after leaving screen
            }

    
        }     
}
