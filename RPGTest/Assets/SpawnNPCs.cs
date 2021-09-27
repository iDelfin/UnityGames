using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNPCs : MonoBehaviour
{
    public GameObject NpcFsd;
    public GameObject NpcLg;
    public GameObject NpcWea;
    public GameObject NpcThr;

    private float CounterTime;
    private int FsdWait;
    private int LgWait;
    private int WeaWait;
    private int ThrWait;
    private float FsdClock;
    private float LgClock;
    private float WeaClock;
    private float ThrClock;
    private int RandomNPC;

    Vector2 NewPos;

    // Start is called before the first frame update
    void Start()
    {
        FsdWait = Random.Range(11, 20);
        LgWait = Random.Range(11, 20);
        WeaWait = Random.Range(11, 20);
        ThrWait = Random.Range(11, 20);
    }

    // Update is called once per frame
    void Update()
    {
        RandomNPC = Random.Range(0, 4);

        CounterTime += 1 * Time.deltaTime;
        //Debug.Log(NpcFsd.active);
        //Debug.Log("FSD: " + FsdClock);
        //Debug.Log("LG: " + LgClock);
        //Debug.Log("THR: " + ThrClock);
        //Debug.Log("WEA: " + WeaClock);
        if ((RandomNPC == 0) && (!NpcFsd.active) && (FsdClock >= FsdWait))
        {
            Debug.Log("Activate");
            NpcFsd.SetActive(true);
            FsdClock = 0;
            FsdWait = Random.Range(4, 11);
        }
        else if ((RandomNPC == 0) && (!NpcFsd.active))
        {
            FsdClock += 2 * Time.deltaTime;
        }

        if ((RandomNPC == 1) && (!NpcLg.active) && (LgClock >= LgWait))
        {
            NpcLg.SetActive(true);
            LgClock = 0;
            LgWait = Random.Range(4, 11);
        }
        else if ((RandomNPC == 1) && (!NpcLg.active))
        {
            LgClock += 2 * Time.deltaTime;
        }

        if ((RandomNPC == 2) && (!NpcThr.active) && (ThrClock >= ThrWait))
        {
            NpcThr.SetActive(true);
            ThrClock = 0;
            ThrWait = Random.Range(4, 11);
        }
        else if ((RandomNPC == 2) && (!NpcThr.active))
        {
            ThrClock += 2 * Time.deltaTime;
        }

        if ((RandomNPC == 3) && (!NpcWea.active) && (WeaClock >= WeaWait))
        {
            NpcWea.SetActive(true);
            WeaClock = 0;
            WeaWait = Random.Range(4, 11);
        }
        else if ((RandomNPC == 3) && (!NpcWea.active))
        {
            WeaClock += 2 * Time.deltaTime;
        }

        if (CounterTime >= 30)
        {
            CounterTime = 0;
        }
    }
}