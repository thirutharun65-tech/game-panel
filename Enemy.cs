using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float maxHealth = 50f;
    private float currentHealth;
    private bool isAlive = true;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    /// <summary>
    /// Enemy takes damage
    /// </summary>
    public void TakeDamage(float damage, DamageSystem.HitLocation hitLocation)
    {
        if (!isAlive)
            return;

        // Apply damage multiplier based on hit location
        float finalDamage = damage;
        if (hitLocation == DamageSystem.HitLocation.Head)
            finalDamage *= 2f; // Headshot deals 2x damage

        currentHealth -= finalDamage;
        Debug.Log($"Enemy Health: {currentHealth}/{maxHealth} (Hit: {hitLocation})");

        if (currentHealth <= 0)
            Die();
    }

    /// <summary>
    /// Enemy dies
    /// </summary>
    private void Die()
    {
        isAlive = false;
        Debug.Log("Enemy Died!");

        // Add death animation, ragdoll, etc.
        Destroy(gameObject, 1f);
    }

    public float GetHealth() => currentHealth;
    public bool IsAlive() => isAlive;
}
