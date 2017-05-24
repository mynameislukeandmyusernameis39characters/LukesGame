Module MyModule
    Private Player As PlayerBase
    Const PlayerPlaceholder As String = "[P]"
    Const WeaponPlaceholder As String = "[W]"
    Const WeaponDamagePlaceholder As String = "[WD]"

    Sub Main()
        Call DisplayWelcomeScreen()

        Console.WriteLine()

        Player = GetNewPlayerClass()
        Console.WriteLine("Player Creation Successful!")
        Console.WriteLine()
        ColorizedWrite($"Welcome to the game, {PlayerPlaceholder} the badass {Player.PlayerClass} !")
        Console.WriteLine()

        Console.WriteLine("Would you like to view your current stats and equipment? y/n")
        If Console.ReadKey(True).KeyChar.ToString = "y" Then DisplayStats()


    End Sub

    Sub ColorizedWrite(text As String)
        Dim parts = text.Split(" ")

        For Each word As String In parts

            If word.Contains(PlayerPlaceholder) Then
                word = word.Replace(PlayerPlaceholder, vbNullString)

                Console.ForegroundColor = ConsoleColor.Magenta
                Console.Write(Player.Name)
                Console.ForegroundColor = ConsoleColor.White
                Console.Write(word)

            ElseIf word.Contains(WeaponPlaceholder) Then

                word = word.Replace(WeaponPlaceholder, vbNullString)

                Console.ForegroundColor = ConsoleColor.Green
                Console.Write(Player.EquippedWeapon.Name)
                Console.ForegroundColor = ConsoleColor.White
                Console.Write(word)

            ElseIf word.Contains(WeaponDamagePlaceholder) Then
                word = word.Replace(WeaponDamagePlaceholder, vbNullString)

                Console.ForegroundColor = ConsoleColor.Red
                If Player.ClassType = "Ranged" Then
                    Console.Write(Player.EquippedWeapon.BaseDamage * Player.RangedModifier)
                Else
                    Console.Write(Player.EquippedWeapon.BaseDamage * Player.PhysicalModifier)
                End If
                Console.ForegroundColor = ConsoleColor.White
                Console.Write(word)

            Else
                Console.Write(word)

            End If

            Console.Write(" ")
        Next
        Console.WriteLine()
    End Sub


    Sub DisplayStats()
        Console.WriteLine()
        ColorizedWrite($"Current Stats for {PlayerPlaceholder}:")
        Console.WriteLine("==================================================")
        ColorizedWrite($"Weapon: {WeaponPlaceholder}, {Replace(Player.EquippedWeapon.GetType.ToString, "LukesGame.", "", 1)}")
        ColorizedWrite($"Weapon Damage: " & WeaponDamagePlaceholder)
        Console.WriteLine("Current Hit Points: " & Player.HitPoints & "/" & Player.MaxHitPoints)
        Console.WriteLine("Level " & Player.Level & " and " & Player.XP & " XP")
        Console.ReadLine()
    End Sub


    Sub DisplayWelcomeScreen()
        Console.WriteLine("A long time ago in a galaxy far, far away...")
    End Sub

    Function GetNewPlayerClass() As PlayerBase

        Console.WriteLine("What is your hero's name?")

        Dim PlayerName = Console.ReadLine()
        Dim NewPlayer As PlayerBase
        Dim PlayerChoice As Integer

        Do
            Console.WriteLine()
            Console.WriteLine("What is your profession?  (Press 1 for Mage, 2 for Monk, 3 for Paladin, 4 for Warrior)")
        Loop Until Integer.TryParse(Console.ReadKey(True).KeyChar.ToString, PlayerChoice)

        Console.WriteLine()

        Debug.Print(PlayerChoice)
        If PlayerChoice = 1 Then
            NewPlayer = Mage.GetStarterMage()
        ElseIf PlayerChoice = 2 Then
            NewPlayer = Monk.GetStarterMonk()
        ElseIf PlayerChoice = 3 Then
            NewPlayer = Paladin.GetStarterPaladin
        ElseIf PlayerChoice = 4 Then
            NewPlayer = Warrior.GetStarterWarrior
        Else
            Console.WriteLine("you haven't chosen a class and I'm too lazy to code for that right now.  Congrats, you're a warrior!")
            NewPlayer = Warrior.GetStarterWarrior
        End If

        NewPlayer.Name = PlayerName.Trim

        Return NewPlayer
    End Function

End Module
