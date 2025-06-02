using UnityEngine;

public class PipeMoove : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float deleteZone = -20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        if (transform.position.x < deleteZone)
        {
            Debug.Log("tuyaux supprimer");
            Destroy(gameObject);
        }
        transform.position +=Vector3.left * moveSpeed*Time.deltaTime;
    }
}
