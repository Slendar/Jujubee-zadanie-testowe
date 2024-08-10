using System;
using UnityEngine;

public class Firearm : MonoBehaviour
{
    #region EVENTS
    public event EventHandler OnAttack;
    #endregion

    [SerializeField] private FirearmSO firearmSO;

    private int ammoAmount = 16;

    private void Start()
    {
        ammoAmount = firearmSO.ammoAmount;

        GameInputSINGLE.Instance.OnLeftClick += Instance_OnLeftClick;
    }

    private void Instance_OnLeftClick(object sender, System.EventArgs e)
    {
        Attack();
    }

    public void Attack()
    {
        if (ammoAmount > 0)
        {
            Debug.Log("Unalive'em from distance Firearm Attack \n Dealt: " + firearmSO.DamageValue + " Damage ; Ammo Left: " + --ammoAmount);
            OnAttack?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            ammoAmount = firearmSO.ammoAmount;
            Debug.Log("Oops, looks like You canno't Unalive'em anymore \n Le'me do a tactical reload for You Ammo Left: " + ammoAmount);
        }
    }

    private void OnDestroy()
    {
        GameInputSINGLE.Instance.OnLeftClick -= Instance_OnLeftClick;
    }
}
