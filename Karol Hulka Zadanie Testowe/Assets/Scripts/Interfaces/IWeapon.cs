using TMPro;
using UnityEngine.AddressableAssets;

public interface IWeapon
{
    public AssetReferenceGameObject Prefab {get; set; }
    public AssetReferenceSprite Sprite { get; set; }
    public string WeaponName { get; set; }
    public TMP_FontAsset FontAsset { get; set; }
    public float DamageValue { get; set; }
    public string Description { get; set; }
}
