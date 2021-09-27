using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject gearDrop;
    public GameObject springDrop;
    public GameObject screwDrop;

    private float CounterTime;
    private float x;
    private float y;
    private int RandomItem;
    Vector2 NewPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RandomItem = Random.Range(0, 3);
        CounterTime += 2 * Time.deltaTime;
        if ((CounterTime >= 3) && (RandomItem == 0))
        {
            x = Random.Range(-1.2f, 3.0f);
            y = Random.Range(-1.5f, 2.5f);
            NewPos = new Vector2(x, y);
            Instantiate(gearDrop, NewPos, transform.rotation);
            CounterTime = 0;
        }
        else if ((CounterTime >= 3) && (RandomItem == 1))
        {
            x = Random.Range(-1.2f, 3.0f);
            y = Random.Range(-1.5f, 2.5f);
            NewPos = new Vector2(x, y);
            Instantiate(springDrop, NewPos, transform.rotation);
            CounterTime = 0;
        }
        else if (CounterTime >= 3)
        {
            x = Random.Range(-1.2f, 3.0f);
            y = Random.Range(-1.5f, 2.5f);
            NewPos = new Vector2(x, y);
            Instantiate(screwDrop, NewPos, transform.rotation);
            CounterTime = 0;
        }
    }
}
