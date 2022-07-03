using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showScore : MonoBehaviour
{
    public UnityEngine.UI.Text Score;
    void Start()
    {
        Score.text = Global.scoreCalc.ToString();
    }
}
