using UnityEngine;

public class CHANGEBOOL : MonoBehaviour
{
    public Collsion_Score check;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            check.check = true;
        }    
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        check.check = false;
    }



}
