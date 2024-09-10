using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Controls : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody = this.GetComponent<Rigidbody2D>();
        this.rigidbody.AddForce(new Vector2((Random.value * 10)-1, 0));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position.Set(this.transform.position.x, 0, 0);
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
