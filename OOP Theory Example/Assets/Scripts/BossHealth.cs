using UnityEngine;

public class BossHealth : CharacterHealth {
    public int[] stageHealth { get; private set; }

    public override void LoseHealth(int damage, Vector3 hitPoint) {
        base.LoseHealth(damage, hitPoint);
        CheckStage();
    }

    void CheckStage() {
        for (int i = stageHealth.Length - 1; i >= 0; --i) {
            if (health <= stageHealth[i]) {
                transform.GetComponent<Boss>().UpdateStage(i + 1);
                break;
            }
        }
    }

    protected override void Die() {
        ShowEffect(deathEffect, transform.position);

        GameManager.instance.LoadNextLevel();

        base.Die();
    }
}
