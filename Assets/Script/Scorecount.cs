using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorecount : MonoBehaviour
{
    private int sc;
    // Start is called before the first frame update
    void Start()
    {

    }
    public float GetCurrentScore()
    {
        return sc;
    }
    public void IncrementScore()
    {
        sc++;
    }
    public int Score
    {
        get { return sc; }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
