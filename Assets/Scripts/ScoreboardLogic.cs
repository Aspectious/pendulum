using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreboardLogic : MonoBehaviour
{
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text = "0";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateText(string newtext)
    {
        text.text = newtext;
    }
}
