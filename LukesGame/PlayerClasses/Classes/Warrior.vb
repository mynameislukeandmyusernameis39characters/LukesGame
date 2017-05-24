Public Class Warrior
    'melee damage, crappy tank
    Inherits PlayerBase

    Public Overrides ReadOnly Property PhysicalModifier As Decimal = 1

    Public Overrides ReadOnly Property RangedModifier As Decimal = 0

    Public Overrides ReadOnly Property HealingModifier As Decimal = 0

    Public Overrides ReadOnly Property ResistanceModifier As Decimal = 0.5

    Public Overrides ReadOnly Property DamageActual As Integer
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Shared Function GetStarterWarrior() As Warrior
        Dim NewChar = New Warrior
        With NewChar
            .EquippedWeapon = New TwinSword With {.Name = "Twin Blades of Greenville", .BaseDamage = 2, .AttackSpeed = 0.5, .BaseHealing = 0, .WeaponLevel = 1}
            .PlayerClass = "Warrior"
            .ClassType = "Melee"
            .Level = 1
            .XP = 0
            .HitPoints = 15
            .MaxHitPoints = 15
        End With

        Return NewChar
    End Function
End Class
