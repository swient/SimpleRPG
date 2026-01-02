using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Weapon weapon;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (weapon != null && Input.GetKeyDown(KeyCode.Space))
        {
            weapon.Attack();
        }
    }

    public void LoadWeapon(Weapon weapon)
    {
        this.weapon = weapon;
    }

    public void UnloadWeapon()
    {
        weapon = null;
    }
}
