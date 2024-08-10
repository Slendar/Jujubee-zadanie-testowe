using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSlotAndNameUI : MonoBehaviour
{
    [SerializeField] private Image weaponImage;
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        PlayerSINGLE.Instance.OnWeaponChanged += Instance_OnWeaponChanged;
    }

    private void Instance_OnWeaponChanged(object sender, PlayerSINGLE.OnWeaponChangedEventArgs e)
    {
        e.currentWeapon.Sprite.LoadAssetAsync().Completed += 
            (asyncOperation) => { 
                weaponImage.sprite = asyncOperation.Result;

                text.text = e.currentWeapon.WeaponName;
                text.font = e.currentWeapon.FontAsset;
            };
         
    }

    private void OnDestroy()
    {
        PlayerSINGLE.Instance.OnWeaponChanged -= Instance_OnWeaponChanged;
    }
}
