
using TMPro;
using UnityEngine;

public class Collsion_Score : MonoBehaviour
{
    public int score = 0;
    public GameObject dest;
    public GameObject coin;


 public bool check;
    public string collider;

 public void Awake()
    {
        check = false;
        //Saying what to destroy
        dest = Instantiate(coin);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            check = true;
            
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        check = false;
    }















    public void Update()
    {
       Debug.Log(check);
       if (check == true && Input.GetKeyDown(KeyCode.Space))
        {
            
 score++;
            Destroy(dest.gameObject);
            dest = Instantiate(coin);
            check = false;
        }

            
        
      
    }







}
