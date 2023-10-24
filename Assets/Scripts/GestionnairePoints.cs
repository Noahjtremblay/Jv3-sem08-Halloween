using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionnairePoints : MonoBehaviour
{


    [SerializeField]
    private InfosPoints _points;


  

    [Space(10)]
[Header("Affichage Points")]
[SerializeField]
private TMP_Text _textPoints;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void AffichagePoints(){

        _textPoints.text = _points.nbPoints.ToString();
    }
}
