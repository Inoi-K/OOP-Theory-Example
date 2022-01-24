using UnityEngine;

public class PlayerHealth : CharacterHealth {
    [SerializeField] ParticleSystem addHealthEffect;

    public void AddHealth(int value) {
        ShowEffect(addHealthEffect, transform.position);

        ChangeHP(value);
    }

    protected override void Die() {
        ShowEffect(deathEffect, transform.position);

        GameManager.instance.ReloadLevel();

        base.Die();
    }
}
