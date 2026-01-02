using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class ScytheWeapon : Weapon
{
    public const string ANIM_PARM_ISATTACK = "IsAttack";

    private Animator anim;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }

    public override void Attack()
    {
        anim.SetTrigger(ANIM_PARM_ISATTACK);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            // TODO
            print("Trigger with " + other.name);
        }
    }
}