using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interfaces : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public interface IDamageable
{
    public Vector3 Position { get; }
    void Damage(float damage);
}
public class PlayerHP : MonoBehaviour, IDamageable
{
    public float startingHealth = 100f;
    float m_CurrentHealth;
    public Vector3 Position
    {
        get
        {
            return transform.position;
        }
    }
    void Start()
    {
        m_CurrentHealth = startingHealth;
    }
    public void Damage(float damage)
    {
        m_CurrentHealth -= damage;
    }
}
public class Explosion : MonoBehaviour
{
    public float range = 10f;
    public float damage = 35f;
    List<IDamageable> m_AllDamageables = new List<IDamageable>();
    void Start()
    {
        MonoBehaviour[] allScripts = FindObjectsOfType<MonoBehaviour>();
        for (int i = 0; i < allScripts.Length; i++)
        {
            if (allScripts[i] is IDamageable)
                m_AllDamageables.Add(allScripts[i] as IDamageable);
        }
    }
    public void Explode()
    {
        for (int i = 0; i < m_AllDamageables.Count; i++)
        {
            if (Vector3.Distance(m_AllDamageables[i].Position, transform.position) < range)
                m_AllDamageables[i].Damage(damage);
        }
    }

}
