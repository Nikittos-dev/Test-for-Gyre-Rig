using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texts : MonoBehaviour
{
    private Text textScore;
    private void Start()
    {
        textScore = gameObject.GetComponent<Text>();
    }
    void Update()
    {
        textScore.text = "Score: " + PlayerPrefs.GetInt("score").ToString();
    }
}
