using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Random = UnityEngine.Random;

public class Controls : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private HingeJoint2D hinge;
    public ScoreboardLogic score;
    private GameObject weight;

    private int timeAboveZero = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody = this.GetComponent<Rigidbody2D>();
        this.hinge = this.GetComponent<HingeJoint2D>();
        this.weight = GameObject.Find("Square");
        this.rigidbody.AddForce(new Vector2((Random.value * 10)-1, 0));
        this.score = GameObject.Find("score").GetComponent<ScoreboardLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = this.hinge.jointAngle;
        rotation %= 360;
        rotation -= 180;
        rotation %= 360;
        if (weight.transform.position.y > 0)
        {
            timeAboveZero += (int) Time.deltaTime;
        }
        else
        {
            timeAboveZero = 0;
        }
        
        score.updateText(rotation.ToString());
        this.transform.position = new Vector3(this.transform.position.x, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            this.rigidbody.AddForce(new Vector2(-100, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.rigidbody.AddForce(new Vector2(100, 0));
        }
    }
}
