using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerSINGLE : MonoBehaviour
{
    public static PlayerSINGLE Instance { get; private set; }

    #region EVENTS
    public event EventHandler<OnWeaponChangedEventArgs> OnWeaponChanged;
    public class OnWeaponChangedEventArgs : EventArgs
    {
        public IWeapon currentWeapon;
    }
    #endregion

    [SerializeField] private List<ScriptableObject> weaponsSOList = new List<ScriptableObject>();

    private List<IWeapon> weaponsList = new List<IWeapon>();

    private int weaponIterator = -1;
    private GameObject spawnedWeapon = null;

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("Player Instance already exists");
        }
        Instance = this;
    }

    private void Start()
    {
        foreach (var weapon in weaponsSOList) 
        {
            if (weapon.IsConvertibleTo<IWeapon>(true)) 
            {
                weaponsList.Add(weapon.ConvertTo<IWeapon>());
            }
            else
            {
                Debug.LogError(weapon.name + "SO in PlayerSINGLE doesn't implement interface: IWeapon and won't be used");
            }
        }

        GameInputSINGLE.Instance.OnRightClick += Instance_OnRightClick;
    }

    private void Instance_OnRightClick(object sender, EventArgs e)
    {
        ChangeWeapon();
    }

    private void ChangeWeapon()
    {
        if (weaponIterator >= 0)
        {
            weaponsList[weaponIterator].Prefab.ReleaseInstance(spawnedWeapon);
            weaponsList[weaponIterator].Sprite.ReleaseAsset();
        }

        weaponIterator = weaponIterator < weaponsSOList.Count - 1 ? weaponIterator + 1 : 0;

        weaponsList[weaponIterator].Prefab.InstantiateAsync(this.transform).Completed +=
            (asyncOperation) => {
                spawnedWeapon = asyncOperation.Result;

                OnWeaponChanged?.Invoke(this, new OnWeaponChangedEventArgs
                {
                    currentWeapon = weaponsList[weaponIterator]
                });
            };
    }

    private void OnDestroy()
    {
        GameInputSINGLE.Instance.OnRightClick -= Instance_OnRightClick;
    }
}