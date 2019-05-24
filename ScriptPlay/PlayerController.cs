 using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public int speed;
    private int count;
    public Text countText;
    public Text winText;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     //   float moveVertical = Input.GetAxis("Vertical");
       // float moveHorizontal = Input.GetAxis("Horizontal");
      //  Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
      //  rb.AddForce(movement * speed);



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
        countText.text = " " + count.ToString();
        if (count >= 15)
        {
            winText.text = "Winner";
            SceneManager.LoadScene("Main");
        }
    }
    //string name = "Main";
    // Update is called once per frame
    void Update()
    {


      /*  if (count == 15)
        {
            
            SceneManager.LoadScene(name);
        }*/

    }
}
