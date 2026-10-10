using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Collsion_WithCind : MonoBehaviour // COIN HAS THIS SCRIPT
{
    public Collsion_Score coll;

    public int score = 0;
    public GameObject dest;
    public GameObject coin;

    

    public string collider;

    public bool check;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
           
            
        }


    }

    public void OnTriggerExit2D(Collider2D collision)
    {

    }






    public void Update()
    {
        Debug.Log(check);
        if (check == true && Input.GetKeyDown(KeyCode.Space))
        {

            score++;
            Destroy(dest.gameObject);
            dest = Instantiate(coin);
        }




    }



}
