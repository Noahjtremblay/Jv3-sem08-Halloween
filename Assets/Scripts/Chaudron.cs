using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaudron : MonoBehaviour
{

    [SerializeField]
    private InfosPoints _infosPoints;

    [SerializeField]
    private GameObject chaudron;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && _infosPoints.chaudron == true){ 

            _infosPoints.nbPoints += 1; //quand le joueur touche le bac le scriptable object de point est augmenté de 1
            _infosPoints.chaudron = false;
    }
}

}
