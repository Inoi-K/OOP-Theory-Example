using UnityEngine;

public class Health : MonoBehaviour {
    public int health;

    public virtual void LoseHealth(int damage, Vector3 hitPoint) {
        health -= damage;
        CheckHP();
    }

    protected void CheckHP() {
        if (health <= 0)
            Die();
    }

    protected virtual void Die() {
        gameObject.SetActive(false);
    }
}
