Public Class Monk
    'healer, crappy melee damage
    Inherits PlayerBase

    Public Overrides ReadOnly Property PhysicalModifier As Decimal = 0.5

    Public Overrides ReadOnly Property RangedModifier As Decimal = 0

    Public Overrides ReadOnly Property HealingModifier As Decimal = 1

    Public Overrides ReadOnly Property ResistanceModifier As Decimal = 0

    Public Overrides ReadOnly Property DamageActual As Integer
        Get
            Throw New NotImplementedException()
        End Get
    End Property



    Public Shared Function GetStarterMonk() As Monk
        Dim NewChar = New Monk
        With NewChar
            .EquippedWeapon = New Mace With {.Name = "Smoked Turkey Drumstick", .BaseDamage = 1, .AttackSpeed = 1.5, .BaseHealing = 2, .WeaponLevel = 1}
            .PlayerClass = "Monk"
            .ClassType = "Melee"
            .Level = 1
            .XP = 0
            .HitPoints = 10
            .MaxHitPoints = 10
        End With

        Return NewChar
    End Function




End Class
