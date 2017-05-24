Public Class Mace
    'healing and physical damage weapon
    Inherits WeaponBase

    Public Overrides ReadOnly Property ActualDamage As Integer
        Get
            ActualDamage = 1
        End Get
    End Property

    Public Overrides ReadOnly Property ActualHealing As Integer
        Get
            ActualHealing = 2
        End Get
    End Property
End Class
