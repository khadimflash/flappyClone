using UnityEngine;

public class PipeMiddleScriptTriggerEnterDetection : MonoBehaviour
{
      public ScoreManagerScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //permet de référencer le gameobeject avec le tag logique et recupérer son composant script
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<ScoreManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && collision.gameObject.layer!=6)
        {
             logic.addscore();   
        }
            
    }
}
