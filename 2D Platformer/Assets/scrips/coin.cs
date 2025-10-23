using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
        [Header("coin Attributes")]
        public int scoreToGive;
        private float startYPos;
        public float bobHeight;
        public float bobSpeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerController2D>().AddScore(scoreToGive);
            Destroy(gameObject);
        }
    }

    void Start()
    {
        startYPos = transform.position.y;
    }

    void Update()
    {
        float newY = startYPos + (Mathf.Sin(Time.time * bobSpeed) * bobHeight);
        transform.position = new Vector3(transform.position.x, newY, 0);
    }
}
