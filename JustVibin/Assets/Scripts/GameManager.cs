using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timerMin, timerMax;
    public GameObject enemyCar;
    float timerForDifficulty;
    // Start is called before the first frame update
    void Start()
    {
        timerMin = 1f; timerMax = 3f;
        StartCoroutine(SpawnEnemyCars());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemyCars()
    {
        yield return new WaitForSecondsRealtime(Random.Range(timerMin, timerMax));
        GameObject EC = Instantiate(enemyCar, new Vector2(Random.Range(-5.5f, 5.5f), 8.5f), Quaternion.identity);
        StartCoroutine(SpawnEnemyCars());
    }
}
