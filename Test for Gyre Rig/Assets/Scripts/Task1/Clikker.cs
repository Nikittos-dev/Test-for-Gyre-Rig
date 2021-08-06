using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Clikker : MonoBehaviour
{
    private GameObject ClikZone;
    private static int score;
    private void Start()
    {
        ClikZone = gameObject.GetComponent<GameObject>();
        score = PlayerPrefs.GetInt("score");
    }
    public void OnClikTigger()
    {
        PlayerPrefs.SetInt("score", score++);
    }
}
