using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu(fileName = "New Firearm", menuName = "Weapons/Firearm")]
public class FirearmSO : ScriptableObject, IWeapon
{
    #region IWEAPON IMPLEMENTATION
    [SerializeField] private AssetReferenceGameObject prefab;
    [SerializeField] private AssetReferenceSprite sprite;
    [SerializeField] private string weaponName = "PlaceHolder";
    [SerializeField] private TMP_FontAsset fontAsset;
    [Range(0.0f, 10.0f)] [SerializeField] private float damageValue = 1;
    [TextArea(10, 100)] [SerializeField] private string description = "PlaceHolder\nLong PlaceHolder";

    public AssetReferenceGameObject Prefab { get => prefab; set => prefab = value; }
    public AssetReferenceSprite Sprite { get => sprite; set => sprite = value; }
    public string WeaponName { get => weaponName; set => weaponName = value; }
    public TMP_FontAsset FontAsset { get => fontAsset; set => fontAsset = value; }
    public float DamageValue { get => damageValue; set => damageValue = value; }
    public string Description { get => description; set => description = value; }
    #endregion

    public int ammoAmount = 16;
    public float weaponRange = 10;
}
