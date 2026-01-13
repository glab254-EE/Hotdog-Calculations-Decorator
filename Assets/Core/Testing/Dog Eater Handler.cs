using System.Collections.Generic;
using UnityEngine;

public class DogEaterHandler : MonoBehaviour
{
    [field:SerializeField]
    List<AHotdog> Hotdogs;
    void Start()
    {
        foreach(AHotdog hotdog in Hotdogs)
        {
            Debug.Log(hotdog.GetName()+" ("+hotdog.GetWeight()+") — "+hotdog.GetCost()+"р.");
        }
    } 
}
