using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigideBody;
    public logicScript logic;
    public float vitesse;
    public bool birdIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("scenes").GetComponent<logicScript>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigideBody.linearVelocity = Vector2.up * vitesse;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        logic.gameOver();
    }
}
