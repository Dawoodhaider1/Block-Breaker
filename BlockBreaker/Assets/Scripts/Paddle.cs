using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool AutoPlay = false;

    private Ball ball;

    void Start()
    {
        ball = GameObject.FindObjectOfType<Ball>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!AutoPlay)
        {
            MovementByMouse();
        }
        else
        {
            autoPlay();
        }
    }

    void autoPlay ()
    {
        Vector3 paddlePos = new Vector3(0f, this.transform.position.y, -1f);
        Vector3 ballpos = ball.transform.position;
        paddlePos.x = Mathf.Clamp(ballpos.x, 1.42f, 14.58f);
        this.transform.position = paddlePos;
    }

    void MovementByMouse()
    {
        Vector3 paddlePos = new Vector3(0f, this.transform.position.y, -1f);
        float mousePosInBlocks = (Input.mousePosition.x / Screen.width) * 16;
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 1.42f, 14.58f);
        this.transform.position = paddlePos;
    }
}
