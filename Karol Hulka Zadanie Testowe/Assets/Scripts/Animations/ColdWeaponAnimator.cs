using UnityEngine;

public class ColdWeaponAnimator : MonoBehaviour
{
    private const string ATTACK = "Attack";
    private const string IDLE_INDEX = "IdleIndex";
    private const string ATTACK_INDEX = "AttackIndex";

    [SerializeField] ColdWeapon coldWeapon;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        coldWeapon.OnAttack += Instance_OnAttack;
    }

    private void Instance_OnAttack(object sender, System.EventArgs e)
    {
        animator.SetInteger(ATTACK_INDEX, Random.Range(0, 2));
        animator.SetTrigger(ATTACK);
    }

    public void SetRandomIdleIndex()
    {
        animator.SetInteger(IDLE_INDEX, Random.Range(0, 2));
    }

    private void OnDestroy()
    {
        coldWeapon.OnAttack -= Instance_OnAttack;
    }
}
