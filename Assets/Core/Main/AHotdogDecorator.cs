using UnityEngine;

abstract public class AHotdogDecorator : AHotdog
{
    protected AHotdog hotdog;
    protected void SetHotdog(AHotdog _hotdog)
    {
        hotdog??=_hotdog; // this variant is used to set hotdog in child's editor window.
    }
}
