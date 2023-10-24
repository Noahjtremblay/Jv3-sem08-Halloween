using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetsPourChaudron : MonoBehaviour
{

    [SerializeField]

    private int _valeur;

    [SerializeField]
    private InfosPoints _infosPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "Player" && _infosPoints.chaudron == false){ 



        _infosPoints.chaudron = true; //dit que le joueur à un déchet et l'indique dans le scriptable Object du joueur.

        Destroy(gameObject);
    }
}

}
