using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop =3; //How many clicks before balloon pops

    public float scaleToIncrease = 0.10f; //Scale increased each time the balloon is clicked

    public int scoreToGive; //Score fiven for the pooped balloon

    private ScoreManager scoreManager; // A variavle to reference the ScoreManager 

    public GameObject popEffect; // Reference Pop Effect Particle System 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Reference ScoreManger Componet*
       // scoreManger = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    
    void OnmouseDown ()
    {
        // Reduce clicks by one
        clickToPop -=1;
        //Increase balloon size 
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop==0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);// ///ubcrease scire*
            Instantiate(popEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }


    // Ubdate is called once per fram
    void Update()
    {

    }
}
