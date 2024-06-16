using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerConttoller : MonoBehaviour
{

    Rigidbody  rb;
    public float speed;
    int count;
    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(H,0,V);
        rb.AddForce(move*speed);
    }

    private void OnTriggerEnter(Collider other) 
    {
        other.gameObject.SetActive(false);
        count += 1;
        Debug.Log(count);
        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "獲得文字数：" + count.ToString();
    }
}
