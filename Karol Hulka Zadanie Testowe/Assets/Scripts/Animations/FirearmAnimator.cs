using UnityEngine;

public class FirearmAnimator : MonoBehaviour
{
    private const string ATTACK = "Attack";
    private const string IDLE_INDEX = "IdleIndex";
    private const string ATTACK_INDEX = "AttackIndex";

    [SerializeField] Firearm firearm;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        firearm.OnAttack += Instance_OnAttack;
    }

    private void Instance_OnAttack(object sender, System.EventArgs e)
    {
        animator.SetTrigger(ATTACK);
    }

    private void OnDestroy()
    {
        firearm.OnAttack -= Instance_OnAttack;
    }
}
