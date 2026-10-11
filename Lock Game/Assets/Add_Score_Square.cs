using TMPro;
using UnityEngine;

public class Add_Score_Square : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score;
    public Collsion_Score Add;
    void Update()
    {
        score.SetText("Score " + Add.score);
    }
}
