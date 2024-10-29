namespace Configs
{
    using ShootEmUp;
    using UnityEngine;

    [CreateAssetMenu(fileName = "Gun", menuName = "Configs/Entities/Gun", order = 0)]
    public class GunConfig : ScriptableObject
    {
        public int Damage = 1;
        public EPhysicsLayer Layer;
        public float Velocity;
        public Color Color;
    }
}