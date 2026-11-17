
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class PlayerCntrl : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody _rb;

    

    public TMP_Text scoreText;

    private int _score = 0;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        
        _rb.AddForce(new Vector3(h, 1, v) * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "CollectiveItems")
        {
            _score++;
            Destroy(other.gameObject);

            if(_score != 5)
            scoreText.text = "Score: " + _score;

            else
            scoreText.text = "You win!";
        }       
    }
}
