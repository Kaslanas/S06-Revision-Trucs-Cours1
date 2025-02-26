using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{        
    
    
    [SerializeField] GameObject _Gold;
    [SerializeField] Vector3 position;
    [SerializeField] Quaternion velocity;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(_Gold, position, velocity);


    }


}
