using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject _Champignon;
    public Vector3 Position2;
    public Vector3 Position1;
    private float Chance = 0f;

    void Start()
    {
        Chance = Random.Range(0f, 1f); 

        if (Chance >= 0.5f) 
        {
            transform.position = Position2;
        }
    
         else{


            transform.position = Position1;

        }
    
    
    }

   
}
