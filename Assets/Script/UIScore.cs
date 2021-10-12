using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    public Text score;
    public Scorecount sc;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        score.text = sc.GetCurrentScore().ToString();
    }
}
