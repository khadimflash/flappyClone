using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{
    public int playerscore;
    public Text textScore;
    //[ContextMenu("le score augmente")]
    public void addscore()
    {
        playerscore++;
        textScore.text = playerscore.ToString();
        Debug.Log(playerscore);
    }
}
