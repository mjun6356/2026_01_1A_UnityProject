using UnityEngine;
using UnityEngine.UI;

public class MyJump : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float power = 200.0f;
    public Text timeUi;
    public float Timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer = Timer + Time.deltaTime;
        timeUi.text = Timer.ToString();


        if (Input.GetKeyDown(KeyCode.Space))
        {
            power= power + Random.Range(-100, 200);
            rigidbody.AddForce(Vector3.up * power);
        }

        if(this.gameObject.transform.position.y > 5 || this.gameObject.transform.position.y < -3)
        {
            Destroy(this.gameObject);
        }

    }
}
