using UnityEngine;

abstract public class AHotdog : ScriptableObject
{
    public abstract string GetName();
    public abstract float GetCost();
    public abstract float GetWeight();
}
