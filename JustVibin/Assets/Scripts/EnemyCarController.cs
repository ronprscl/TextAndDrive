using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarController : MonoBehaviour
{
    GameObject player;
    int random;
    float randomXPos;
    // Start is called before the first frame update
  
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        random = Random.Range(0, 3);
        randomXPos = Random.Range(-5.8f, 5.9f);
        Debug.Log(random);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    void Move()
    {
        switch (random)
        {
            case 0:
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(randomXPos, -12), 0.02f);
                break;
            case 1:
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x, -12), 0.03f);
                break;
            case 2:
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, -12), 0.02f);
                break;
        }
        if(transform.position.y <= -12)
        {
            Destroy(gameObject);
        }
       
    }
}
