Public MustInherit Class PlayerBase

    Public Property Name As String

    Public Property PlayerClass As String

    Public Property ClassType As String

    Public Property Level As Integer

    Public Property XP As Integer

    Public Property HitPoints As Integer

    Public Property MaxHitPoints As Integer

    Public Property EquippedWeapon As WeaponBase

#Region "Overridable Properties"

    Public Overridable ReadOnly Property PhysicalModifier As Decimal = 1

    Public Overridable ReadOnly Property RangedModifier As Decimal = 1

    Public Overridable ReadOnly Property HealingModifier As Decimal = 1

    Public Overridable ReadOnly Property ResistanceModifier As Decimal = 1

    Public Overridable ReadOnly Property HealingActual As Integer = 0

#End Region

    Public MustOverride ReadOnly Property DamageActual As Integer


End Class
