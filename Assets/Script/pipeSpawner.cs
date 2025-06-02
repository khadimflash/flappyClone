using System.Threading;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 20;//combien de temps va etre entre deux génération(ou deux instnaces)
    private float timer = 0;//un compteur
    public float hightOffset = 12; // le plus grand décalage
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pipeGenerator();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            pipeGenerator();
            timer = 0;
        }
    }
    void pipeGenerator()
    {
        float lowesPoint = transform.position.y - hightOffset;
        float hightesPoint = transform.position.y + hightOffset;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowesPoint,hightesPoint),0), transform.rotation);
    }
}
