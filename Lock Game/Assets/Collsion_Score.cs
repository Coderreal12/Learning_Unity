
using TMPro;
using UnityEngine;

public class Collsion_Score : MonoBehaviour
{
    public int score = 0;
    public GameObject dest;
    public GameObject coin;


 public bool check;
    public string collider;

    public Collsion_Score newcheck;
 public void Awake()
    {
        check = false;
        //Saying what to destroy
        dest = Instantiate(coin);
    }

  














    public void Update()
    {
        check = newcheck.check;
       if (check == true && Input.GetKeyDown(KeyCode.Space))
        {
            
 score++;
            Destroy(dest.gameObject);
            dest = Instantiate(coin);
            check = newcheck.check;
        }

            
        
      
    }







}
