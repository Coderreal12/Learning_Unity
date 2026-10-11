using UnityEngine;

public class Blocker : MonoBehaviour
{
    public Rotate block;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
block.input = false;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        block.input = true;
    }



}
