using UnityEngine;
using TMPro;
public class Set_Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score;
    public Collide_With_Coin Add;
    void Update()
    {
        score.SetText("Score " + Add.score);
    }
}
