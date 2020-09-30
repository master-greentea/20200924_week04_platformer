using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingEffects : MonoBehaviour
{
    float huePercent = 1;
    public SpriteRenderer ending;
    void Update()
    {
        ending.color = Color.HSVToRGB(Mathf.PingPong(Time.time, huePercent), 1f, 1f);
    }
}
