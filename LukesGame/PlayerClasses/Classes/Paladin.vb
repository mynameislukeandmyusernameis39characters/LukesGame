Public Class Paladin
    'Tank, crappy melee damage
    Inherits PlayerBase

    Public Overrides ReadOnly Property PhysicalModifier As Decimal = 0.5

    Public Overrides ReadOnly Property RangedModifier As Decimal = 0

    Public Overrides ReadOnly Property HealingModifier As Decimal = 0

    Public Overrides ReadOnly Property ResistanceModifier As Decimal = 1

    Public Overrides ReadOnly Property DamageActual As Integer
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Shared Function GetStarterPaladin() As Paladin
        Dim NewChar = New Paladin
        With NewChar
            .EquippedWeapon = New SwordandBoard With {.Name = "Kitchen Knife and Cutting Board", .BaseDamage = 1, .AttackSpeed = 1, .BaseHealing = 0, .WeaponLevel = 1}
            .PlayerClass = "Paladin"
            .ClassType = "Melee"
            .Level = 1
            .XP = 0
            .HitPoints = 20
            .MaxHitPoints = 20
        End With

        Return NewChar
    End Function
End Class
