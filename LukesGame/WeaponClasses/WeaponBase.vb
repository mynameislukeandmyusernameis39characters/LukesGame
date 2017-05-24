Public MustInherit Class WeaponBase
    Public Property Name As String
    Public Property BaseDamage As Integer
    Public Property BaseHealing As Integer
    Public Property AttackSpeed As Decimal
    Public Property WeaponLevel As Integer
    Public MustOverride ReadOnly Property ActualDamage As Integer
    Public MustOverride ReadOnly Property ActualHealing As Integer

End Class
