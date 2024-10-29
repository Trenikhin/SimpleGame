namespace ShootEmUp
{
	using System;
	using UnityEngine;

	public interface IDamageable
	{
		void TakeDamage(int damage);
	}

	public class Health : MonoBehaviour, IDamageable
	{
		[SerializeField] int _health = 100;
		[field: SerializeField] public int Value { get; private set; }
		public Action<int> OnHealthChanged;
		public Action OnHealthEmpty;
		public int MaxHealth => _health;

		public void Start()
		{
			Value = _health;
		}

		public void TakeDamage(int damage)
		{
			if (Value <= 0)
				return;

			Value = Mathf.Max(0, Value - damage);
			OnHealthChanged?.Invoke(Value);

			if (Value <= 0)
				OnHealthEmpty?.Invoke();
		}

		public void ResetHealth()
		{
			Value = MaxHealth;
		}
	}
}