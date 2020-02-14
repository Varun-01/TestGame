using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    // Update is call ed once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
