using Unity.VisualScripting;
using UnityEngine;

public class Collide_With_Coin : MonoBehaviour
{

    private bool touching = false;
    public GameObject Coin;
    public GameObject dest;
    public float score = 0;
    public Move_Circle Bar;

    [SerializeField] private Canvas Death_Screen;

    [SerializeField] private Canvas Score_Screen;

    private void Start()
    {
        Death_Screen.enabled = false;
        dest = Instantiate(Coin);
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            
            touching = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {

        touching = false;

    }

    private void Update()
    {

        if (touching == true && Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(dest);

            dest = Instantiate(Coin);
            Bar.speed += score * .5f;
            score++;
            Debug.Log("Point");
            

            


        }

        else if(touching == false && Input.GetKeyDown(KeyCode.Space))
        {
            Bar.speed = 0;
            Death_Screen.enabled = true;
            Score_Screen.enabled = false;
        }
            

        
    }

    
    }
