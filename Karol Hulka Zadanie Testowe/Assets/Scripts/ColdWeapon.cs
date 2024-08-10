using System;
using UnityEngine;

public class ColdWeapon : MonoBehaviour
{
    #region EVENTS
    public event EventHandler OnAttack;
    #endregion

    [SerializeField] private ColdWeaponSO coldWeaponSO;

    private float sharpness = 20;

    private void Start()
    {
        sharpness = coldWeaponSO.sharpness;

        GameInputSINGLE.Instance.OnLeftClick += Instance_OnLeftClick;
    }

    private void Instance_OnLeftClick(object sender, System.EventArgs e)
    {
        Attack();
    }

    public void Attack()
    {
        if (sharpness > 0)
        {
            if (coldWeaponSO.isKindness) 
            { 
                Debug.Log("Kill'em with Kindness \n Dealt: " + coldWeaponSO.DamageValue + " Kindness Damage ; Sharpness: " + --sharpness);
            } 
            else
            {
                Debug.Log("Slash'em Cold Weapon Attack \n Dealt: " + coldWeaponSO.DamageValue + " Damage ; Sharpness: " + --sharpness);
            }
            OnAttack?.Invoke(this, EventArgs.Empty);
        }
        else 
        {
            sharpness = coldWeaponSO.sharpness;
            Debug.Log("Oops, looks like You canno't Slash'em anymore \n Le'me fix that quickly for You Sharpness: " + sharpness);
        }
    }

    private void OnDestroy()
    {
        GameInputSINGLE.Instance.OnLeftClick -= Instance_OnLeftClick;
    }
}
