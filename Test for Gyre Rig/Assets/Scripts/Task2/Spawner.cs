using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public Transform SpawPos;
    public GameObject Cube;
    public float TimeSpawn;
    public float TimerSpawn;
    public Text spawnTest;
    public Text speedText;
    public Text destroyText;
    void Start()
    {
        StartCoroutine(SpawnCD());
        TimeSpawn = Random.Range(0.5f, 3.5f);

    }
    private void Update()
    {

        TimerSpawn = TimerSpawn - Time.deltaTime;
        speedText.text ="Speed: " + Move.speed.ToString();
        destroyText.text ="Distanse: " + Move.position.ToString();
        spawnTest.text ="Time to spawn: "+ TimerSpawn.ToString();
    }
    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        TimerSpawn = TimeSpawn;
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(Cube, SpawPos.position, Quaternion.identity);
        Repeat();
    }
}
