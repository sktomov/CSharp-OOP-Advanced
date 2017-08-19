public interface IWeapon
{
    string Name { get; set; }
    int MinDamage { get; set; }
    int MaxDamage { get; set; }
    int NumberOfSockets { get; set; }
    WeaponType WeaponType { get; set; }
    Rare Rare { get; set; }
}

