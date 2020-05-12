using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;


public class playermov : MonoBehaviour
{

    protected Joystick joystick;
    public GameObject pauseMenuUI2;
    public GameObject pauseMenuUI3;
    public GameObject pauseMenuUI4;
    public GameObject pauseMenuUI5;

    public float speed;
    public Text countText;
    public Text winText;
    public Text timer;
    public Button parar3;
    public Rigidbody rb;
    public int count;
    public Vector3 antespausa;

    float currentTime = 0f;
    float startingTime = 100f;
    public Text countdown;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
        currentTime = startingTime;
    }

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            parar();
        }

        var rigidbody = GetComponent<Rigidbody>();

        Vector3 movement = new Vector3(joystick.Horizontal, 0.0f, joystick.Vertical);

        rigidbody.AddForce(movement * speed);


        currentTime -= 1 * Time.deltaTime;
        countdown.text = "TIME:" + currentTime.ToString("0.0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = " COUNT: " + count.ToString();
        if (count >= 10)
        {
            winText.text = "YOU WIN";
            pauseMenuUI2.SetActive(true);
            pauseMenuUI3.SetActive(false);
            pauseMenuUI4.SetActive(false);
            pauseMenuUI5.SetActive(true);
            Time.timeScale = 0f;

        }
    }

    public void parar()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
    }

    public void pause()
    {
        var rigidbody = GetComponent<Rigidbody>();

         antespausa= rigidbody.velocity;
        
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
    }

    public void unpause()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = antespausa;

       
    }

}