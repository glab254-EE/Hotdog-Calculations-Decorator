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

    void OnEnable()
    {
        SetHotdog(_hotdog);
    }
    public override float GetCost()
    {
        
        return hotdog.GetCost() + AdditionalCost;
    }

    public override string GetName()
    {
        return hotdog.GetName() + HotdogAditionalName;
    }

    public override float GetWeight()
    {
        return hotdog.GetWeight() + HotdogAddedWeight;
    }
}
