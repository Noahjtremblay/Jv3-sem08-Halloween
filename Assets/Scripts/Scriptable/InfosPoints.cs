using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfosPoints", menuName = "SO/NombrePoints")]
public class InfosPoints : ScriptableObject
{
    public int nbPoints;

 

    public bool chaudron;


    public void ResetPoints(){

        nbPoints= 0;

       
    }
}
