using UnityEngine;
using UnityEngine.SceneManagement;
public class Go_To_Game : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Gotogame()
    {
        SceneManager.LoadScene(1);
    }
}
