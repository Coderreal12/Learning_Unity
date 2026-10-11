using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rotate : MonoBehaviour
{
    string[] hitbox = { "Right", };
    private string tag;
    public bool flip = true;
    public int Direction = 0;
    
    public string tg;
    public Transform Player;

    public bool input;

    private bool count;
    //Scripts
    public Square_Roate direction;

    public Collsion_Score tru;
    private float time = 0;
    public void Update()
    {
        
        //Getting a positive or negitive value for each keyboard press
        flop(ref flip, input);
        Convert(ref Direction, flip);

        //IF it touches in the same frame then null flip;
        

       
       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
       
        //ANY hitbox
        
 tag = collision.tag;

        
        

       
        switch(tag)
        {

            

           
            case "Right":
               
                if (flip == true)
                {
                    direction.up = true;
                   
                
                }
                else
                {
                    direction.up = false;

                }

                break;
            case "Down":
            if (flip == true && direction.up == true)
                {
                    direction.up = false;
                    flip = false;
                    break;
                }
            else 
                {
                    direction.up = !direction.up;

                    flip = !flip;

                }
                break;
            case "Up":
               if (flip == false && direction.up == false)
                {
                    flip = true;
                    direction.up = true;
                }
                else
                {
                    direction.up = false;
                    flip = true;
                }

                    break;
            case "Left":
                if (flip == false &&  direction.up == false)
                {
                    direction.up = true;
                    flip = false;
                }
                else
                {

                    direction.up = false;
                }
               break;
            default:
                break;
                

        }

}


   


   
    //functions
    public static void flop(ref bool flip, bool input)
    {
        if (Input.GetKeyDown(KeyCode.Space) && input == true)
        {
 flip = !flip;
        }
           
    }

    public static void Convert(ref int Direction, bool flip)
    {
        switch(flip)
        {
            case true:
                Direction = 1;
                break;
            case false:
                Direction = -1;
                break;

        }
    }

}
