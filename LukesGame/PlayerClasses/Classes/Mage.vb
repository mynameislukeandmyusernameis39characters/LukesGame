Public Class Mage
    'ranged damage, crappy healer
    Inherits PlayerBase

    Public Overrides ReadOnly Property PhysicalModifier As Decimal = 0

    Public Overrides ReadOnly Property RangedModifier As Decimal = 1

    Public Overrides ReadOnly Property HealingModifier As Decimal = 0.5

    Public Overrides ReadOnly Property ResistanceModifier As Decimal = 0

    Public Overrides ReadOnly Property DamageActual As Integer
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Shared Function GetStarterMage() As Mage
        Dim NewChar = New Mage
        With NewChar
            .EquippedWeapon = New Staff With {.Name = "Shower Curtain Rod", .BaseDamage = 2, .AttackSpeed = 1, .BaseHealing = 1, .WeaponLevel = 1}
            .PlayerClass = "Mage"
            .ClassType = "Ranged"
            .Level = 1
            .XP = 0
            .HitPoints = 10
            .MaxHitPoints = 10
        End With

        Return NewChar
    End Function
End Class
