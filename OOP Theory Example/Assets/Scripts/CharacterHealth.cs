using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : Health {
    [SerializeField] protected Slider slider;
    [SerializeField] protected ParticleSystem loseHealthEffect;
    [SerializeField] protected ParticleSystem deathEffect;

    int maxHealth;

    private void Start() {
        maxHealth = health;
    }

    public override void LoseHealth(int damage, Vector3 hitPoint) {
        ShowEffect(loseHealthEffect, hitPoint);

        ChangeHP(-damage);
        CheckHP();
    }

    protected void ChangeHP(int value) {
        health += value;
        health = Mathf.Min(health, maxHealth);
        slider.value = health;
    }

    protected void ShowEffect(ParticleSystem effect, Vector3 position) {
        effect.transform.position = position;
        effect.Play();
    }
}
