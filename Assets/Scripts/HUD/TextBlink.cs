using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBlink : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    private float alpha;
    void Update()
    {
        alpha = Mathf.Abs(Mathf.PingPong(Time.time*2, 1) - 1);
        textMesh.color = new Color(255,255,255,alpha);
    }
}
