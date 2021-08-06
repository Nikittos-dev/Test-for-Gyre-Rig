using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Move : MonoBehaviour
{
    public static float speed;
    public static Vector3 position;

    private void Start()
    {
        position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        speed = Random.Range(1,3);

    }
    void FixedUpdate()
    {
        transform.Translate(speed * position * Time.deltaTime, Space.World);
        if (transform.position.x > 5 || transform.position.y > 5 || transform.position.z > 5 || transform.position.x < -15 || transform.position.y < -15 || transform.position.z < -15)
        {
            Destroy(gameObject);
        }
    }
}
