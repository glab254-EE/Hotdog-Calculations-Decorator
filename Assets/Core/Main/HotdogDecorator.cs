using UnityEngine;

[CreateAssetMenu(fileName ="New Hotdog Decoration",menuName ="SO/hotdog decor")]
public class HotdogDecorator : AHotdogDecorator
{
    [field:SerializeField]
    private float AdditionalCost = 210;
    [field:SerializeField]
    private string HotdogAditionalName = "Класический Хотдог";
    [field:SerializeField]
    private float HotdogAddedWeight = 150;
    [field:SerializeField]
    private AHotdog _hotdog;
    public override float GetCost()
    {
        base.SetHotdog(_hotdog); // failsafe
        return base.GetCost() + AdditionalCost;
    }

    public override string GetName()
    {
        base.SetHotdog(_hotdog); // failsafe
        return base.GetName() + HotdogAditionalName;
    }

    public override float GetWeight()
    {
        base.SetHotdog(_hotdog); // failsafe
        return base.GetWeight() + HotdogAddedWeight;
    }
}
