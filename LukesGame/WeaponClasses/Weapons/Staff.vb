Public Class Staff
    'healing and ranged damage weapon
    Inherits WeaponBase

    Public Overrides ReadOnly Property ActualDamage As Integer
        Get
            ActualDamage = 2
        End Get
    End Property

    Public Overrides ReadOnly Property ActualHealing As Integer
        Get
            ActualHealing = 1
        End Get
    End Property
End Class
