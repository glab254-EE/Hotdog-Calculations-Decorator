using UnityEngine;

[CreateAssetMenu(fileName ="New Hotdog",menuName ="SO/base hotdog")]
public class Hotdog : AHotdog
{
    [field:SerializeField]
    private float BaseCost = 210;
    [field:SerializeField]
    private string HotdogName = "Класический Хотдог";
    [field:SerializeField]
    private float HotdogWeight = 150;
    public override float GetCost() => BaseCost;

    public override string GetName() => HotdogName;

    public override float GetWeight() => HotdogWeight;
}
