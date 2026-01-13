using UnityEngine;

abstract public class AHotdogDecorator : AHotdog
{
    protected AHotdog hotdog;
    protected void SetHotdog(AHotdog _hotdog)
    {
        hotdog??=_hotdog; // this variant is used to set hotdog in child's editor window.
    }
    public override float GetCost()
    {
        return hotdog.GetCost();
    }
    public override string GetName()
    {
        return hotdog.GetName();
    }
    public override float GetWeight()
    {
        return hotdog.GetWeight();
    }
}
