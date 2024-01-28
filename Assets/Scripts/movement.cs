using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class movement : MonoBehaviour
{
    public Rigidbody2D ball;
    public float bounceForce;

    public Color turquoiseColor, yellowColor, purpleColor, pinkColor;
    public string currentColor;
    public SpriteRenderer painter;
    public Transform changer;
    public TextMeshProUGUI scoreText;
    public int score;
    public Transform control1, control2, cycle1, cycle2;
    public AudioSource ziplamaSesi;

    void Start()
    {
        turn.turnSpeed = 0.15f;
        RandomColor();
    }

    void Update()
    {
        //Debug.Log(turn.turnSpeed);
        scoreText.text = "Score: " + score;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ball.velocity = Vector2.up * bounceForce;
            ziplamaSesi.Play();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != currentColor && collision.tag != "ColorChanger" && collision.tag != "Control1" && collision.tag != "Control2")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (collision.tag == "ColorSwitch")
        {
            score++;
            changer.position = new Vector3(changer.position.x, changer.position.y + 6f, changer.position.z);
            RandomColor();
            turn.turnSpeed += 0.015f;
        }
        if (collision.tag == "Control1")
        {
            control1.position = new Vector3(control1.position.x, control1.position.y + 12f, control1.position.z);
            cycle1.position = new Vector3(cycle1.position.x, cycle1.position.y + 12f, cycle1.position.z);
        }
        if (collision.tag == "Control2")
        {
            control2.position = new Vector3(control2.position.x, control2.position.y + 12f, control2.position.z);
            cycle2.position = new Vector3(cycle2.position.x, cycle2.position.y + 12f, cycle2.position.z);
        }
    }

    void RandomColor()
    {
        int random = Random.Range(0, 4);

        switch (random)
        {
            case 0:
                currentColor = "Turquoise";
                painter.color = turquoiseColor;
                break;

            case 1:
                currentColor = "Yellow";
                painter.color = yellowColor;
                break;

            case 2:
                currentColor = "Purple";
                painter.color = purpleColor;
                break;

            case 3:
                currentColor = "Pink";
                painter.color = pinkColor;
                break;
        }
    }
}
