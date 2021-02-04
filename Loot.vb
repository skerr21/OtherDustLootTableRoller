Public Class Loot

    Public Shared Function LootRoll(Loot As String)
        Dim x As Integer = 0
        Dim z As Integer = 0
        Dim randomloot As String
        Dim ration As Boolean = False
        Dim randomchance As Boolean = False
        Dim hundred As New Die(100)
        Dim sixSide As New Die(6)
        'Dim int As New Integer
        Dim twentyside As New Die(20)
        Dim twoside As New Die(2)
        Dim weapon As String
        Dim armor As String
        Dim rareitems As String
        Dim rarecount As Integer
        Dim randomloot2 As String
        Dim lootstring As String
        Dim lootamount As Integer
        Dim weaponamount As Integer
        Dim armoramount As Integer

        Dim fourside As New Die(4)
        Dim eightside As New Die(8)
        Dim tenside As New Die(10)
        Dim threeside As New Die(3)

        Dim list As New List(Of String)
        If Loot = "Impoverished Rabble" Then

            If LootTable.FiftyPercent() = True Then
                ration = True
            End If
            If LootTable.FiftyPercent() = True Then
                randomchance = True
            End If

            If ration = True And randomchance = True Then
                If randomloot = "" Then
                    Form1.RichTextBox1.Text = "Weapon: " & LootTable.Weapon(sixSide.Roll) & "
Armor: " & LootTable.Armor(sixSide.Roll) & "
Random Loot: " & "None" & "and One Ration"
                Else
                    Form1.RichTextBox1.Text = "Weapon: " & LootTable.Weapon(sixSide.Roll) & "
Armor: " & LootTable.Armor(sixSide.Roll) & "
Random Loot: " & randomloot & "and One Ration"
                End If

                'End If

            ElseIf ration = True And randomchance = False Then
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.Weapon(sixSide.Roll) & "
Armor: " & LootTable.Armor(sixSide.Roll) &
                    "
One Ration"
            ElseIf ration = False And randomchance = False Then
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.Weapon(sixSide.Roll) & "
Armor: " & LootTable.Armor(sixSide.Roll)
            End If

            '            If twoside.Roll = 1 Then
            '                'do nothing
            '            Else
            '                randomloot = LootTable.RandomLoot(twentyside.Roll)
            '            End If
            '            If randomloot = "" And ration = True Then
            '
            '            Else
            '

        ElseIf Loot = "Raider/Tribal Warrior" Then
            If LootTable.TwentyFivePercent = True Then
                randomchance = True
            End If

            If randomchance = False Then
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.Weapon((sixSide.Roll + 4)) & "
Armor: " & LootTable.Armor(sixSide.Roll + 4) & " and One Ration"
            ElseIf randomchance = True Then
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.Weapon((sixSide.Roll + 4)) & "
Armor: " & LootTable.Armor(sixSide.Roll + 4) & "
Random Loot: " & LootTable.RandomLoot((twentyside.Roll + 3)) & " and One Ration"

            End If

        ElseIf Loot = "Elite Warrior" Then
            If LootTable.FiftyPercent = True Then
                randomchance = True
            End If

            If randomchance = False Then
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.Weapon((sixSide.Roll + 6)) & "
Armor: " & LootTable.Armor(sixSide.Roll + 6) & " and " & fourside.Roll & " Rations"
            Else
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.Weapon((sixSide.Roll + 4)) & "
Armor: " & LootTable.Armor(sixSide.Roll + 4) & "
Random Loot: " & LootTable.RandomLoot((twentyside.Roll + 5)) & " and " & fourside.Roll & " Rations"
            End If
        ElseIf Loot = "Tribal Chieftain" Then

            Form1.RichTextBox1.Text = "Weapon: " & LootTable.Weapon((sixSide.Roll + 10)) & "
Armor: " & LootTable.Armor(eightside.Roll + 8) & "
Random: " & LootTable.RandomLoot((twentyside.Roll + 10))
        ElseIf Loot = "TL3 Warrior/Raider" Then

            If LootTable.FiftyPercent = True Then
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.Weapon((sixSide.Roll + 12)) & "
Armor: " & LootTable.Armor(sixSide.Roll + 1) & "
Random: " & LootTable.RandomLoot((twentyside.Roll + 5))
            Else
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.Weapon((sixSide.Roll + 12)) & "
Armor: " & LootTable.Armor(sixSide.Roll + 1)

            End If
        ElseIf Loot = "TL4 Common Citizen" Then
            If LootTable.FiftyPercent = True Then
                Form1.RichTextBox1.Text = "Laser Pistol, Old Terran Clothing" & "
Random: " & LootTable.RandomLoot((twentyside.Roll + 5))
            Else
                Form1.RichTextBox1.Text = "Laser Pistol, Old Terran Clothing"


            End If

        ElseIf Loot = "TL4 Gunman" Then
            If LootTable.FiftyPercent = True Then
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.Weapon((sixSide.Roll + 20)) & "
Armor: " & LootTable.Armor(fourside.Roll + 18) & "
Random: " & LootTable.RandomLoot((twentyside.Roll + 10))
            Else
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.Weapon((sixSide.Roll + 20)) & "
Armor: " & LootTable.Armor(fourside.Roll + 18)

            End If
        ElseIf Loot = "TL4 Beamgunner" Then
            If LootTable.FiftyPercent = True Then
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.EnergyWeapon((fourside.Roll + 2)) & "
Armor: " & LootTable.Armor(fourside.Roll + 18) & "
Random: " & LootTable.RandomLoot((twentyside.Roll + 12))
            Else
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.EnergyWeapon((fourside.Roll + 2)) & "
Armor: " & LootTable.Armor(fourside.Roll + 18)
            End If
        ElseIf Loot = "TL4 Elite Soldier" Then
            If LootTable.FiftyPercent = True Then
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.EnergyWeapon((sixSide.Roll + 6)) & "
Armor: " & LootTable.Armor(sixSide.Roll + 18) & "
Random: " & LootTable.RandomLoot((twentyside.Roll + 12))
            Else
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.EnergyWeapon((sixSide.Roll + 6)) & "
Armor: " & LootTable.Armor(sixSide.Roll + 18)
            End If
        ElseIf Loot = "TL4 Champion" Then
            Form1.RichTextBox1.Text = "Weapon: " & LootTable.EnergyWeapon((fourside.Roll + 10)) & "
Armor: " & LootTable.Armor(sixSide.Roll + 20) & "
Random: " & LootTable.RandomLoot((twentyside.Roll + 20))

        ElseIf Loot = "Animal Nest" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0

            If LootTable.FiftyPercent = True Then
                list.Add("weapon")
            End If
            If LootTable.FiftyPercent = True Then
                list.Add("armor")
            End If
            If LootTable.FiftyPercent = True Then
                list.Add("random")
            End If


            If list.Contains("weapon") And list.Contains("armor") And list.Contains("random") Then
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.EnergyWeapon((tenside.Roll)) & "
Armor: " & LootTable.Armor(tenside.Roll) & "
Random: " & LootTable.RandomLoot((twentyside.Roll))
            ElseIf list.Contains("weapon") And list.Contains("armor") And list.Contains("random") = False Then
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.EnergyWeapon((tenside.Roll)) & "
Armor: " & LootTable.Armor(tenside.Roll)
            ElseIf list.Contains("weapon") And list.Contains("armor") = False And list.Contains("random") = False Then
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.EnergyWeapon((tenside.Roll))
            ElseIf list.Contains("weapon") = False And list.Contains("armor") And list.Contains("random") Then
                Form1.RichTextBox1.Text = "Armor: " & LootTable.Armor(tenside.Roll) & "
Random: " & LootTable.RandomLoot((twentyside.Roll))
            ElseIf list.Contains("weapon") = False And list.Contains("armor") = False And list.Contains("random") Then
                Form1.RichTextBox1.Text = "Random: " & LootTable.RandomLoot((twentyside.Roll))
            ElseIf list.Contains("weapon") And list.Contains("armor") = False And list.Contains("random") Then
                Form1.RichTextBox1.Text = "Weapon: " & LootTable.EnergyWeapon((tenside.Roll)) & "
Random: " & LootTable.RandomLoot((twentyside.Roll))
            ElseIf list.Contains("weapon") = False And list.Contains("armor") And list.Contains("random") = False Then
                Form1.RichTextBox1.Text = "Armor: " & LootTable.Armor(tenside.Roll)
            End If
        ElseIf Loot = "Armory, Mandate" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            If LootTable.FiftyPercent = True Then
                ration = True

            End If
            If LootTable.FiftyPercent = True Then
                randomchance = True
            End If

            If ration = True And randomchance = True Then ' Ration = chance of armor, randomchance = chance of 1d6 tl5 spare parts
                weaponamount = sixSide.Roll
                While x < weaponamount
                    weapon &= LootTable.EnergyWeapon(tenside.Roll + 4) & ", "

                    x += 1
                End While
                weapon = weapon.TrimEnd(" ")
                weapon = weapon.TrimEnd(",")
                armoramount = sixSide.Roll
                While z < armoramount
                    armor &= LootTable.Armor(eightside.Roll + 18) & ", "
                    z += 1
                End While
                armor = armor.TrimEnd(" ")
                armor = armor.TrimEnd(",")
                Form1.RichTextBox1.Text = "Weapons: " & weapon & "
Armor: " & sixSide.Roll & " suits of Harmony Armor, and " & armor & "
Random: " & sixSide.Roll & " TL4 Spare Parts, " & sixSide.Roll & "TL5 Spare Parts, " & ((sixSide.Roll + sixSide.Roll)) & " Type A Power Cells"

            ElseIf ration = False And randomchance = True Then
                weaponamount = sixSide.Roll
                While x < weaponamount
                    weapon &= LootTable.EnergyWeapon(tenside.Roll + 4) & ", "

                    x += 1
                End While
                weapon = weapon.TrimEnd(" ")
                weapon = weapon.TrimEnd(",")
                armoramount = sixSide.Roll

                Form1.RichTextBox1.Text = "Weapons: " & weapon & "
Armor: " & sixSide.Roll & " suits of Harmony Armor" & "
Random: " & sixSide.Roll & " TL4 Spare Parts, " & sixSide.Roll & "TL5 Spare Parts, " & ((sixSide.Roll + sixSide.Roll)) & " Type A Power Cells"
            ElseIf ration = True And randomchance = False Then
                weaponamount = sixSide.Roll
                While x < weaponamount
                    weapon &= LootTable.EnergyWeapon(tenside.Roll + 4) & ", "

                    x += 1
                End While
                weapon = weapon.TrimEnd(" ")
                weapon = weapon.TrimEnd(",")
                armoramount = sixSide.Roll
                While z < armoramount
                    armor &= LootTable.Armor(eightside.Roll + 18) & ", "
                    z += 1
                End While
                armor = armor.TrimEnd(" ")
                armor = armor.TrimEnd(",")
                Form1.RichTextBox1.Text = "Weapons: " & weapon & "
Armor: " & sixSide.Roll & " suits of Harmony Armor, and " & armor & "
Random: " & sixSide.Roll & " TL4 Spare Parts, " & ((sixSide.Roll + sixSide.Roll)) & " Type A Power Cells"
            End If
            x = 0
            z = 0
        ElseIf Loot = "Armory, Raider" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            If LootTable.FiftyPercent = True Then


                weaponamount = sixSide.Roll
                While x < weaponamount
                    weapon &= LootTable.Weapon(tenside.Roll + 2) & ", "

                    x += 1
                End While
                weapon = weapon.TrimEnd(" ")
                weapon = weapon.TrimEnd(",")
                armoramount = sixSide.Roll
                While z < armoramount
                    armor &= LootTable.Armor(tenside.Roll + 3) & ", "
                    z += 1
                End While
                armor = armor.TrimEnd(" ")
                armor = armor.TrimEnd(",")
                Form1.RichTextBox1.Text = "Weapons: " & weapon & ", " & LootTable.Weapon(sixSide.Roll + 9) & "
Armor: " & armor & "
Random: " & sixSide.Roll & " TL2 Spare Parts " & "and " & fourside.Roll * 20 & " Rounds of ammo"


            Else



                weaponamount = sixSide.Roll
                While x < weaponamount
                    weapon &= LootTable.Weapon(tenside.Roll + 2) & ", "

                    x += 1
                End While
                weapon = weapon.TrimEnd(" ")
                weapon = weapon.TrimEnd(",")
                armoramount = sixSide.Roll
                While z < armoramount
                    armor &= LootTable.Armor(tenside.Roll + 3) & ", "
                    z += 1
                End While
                armor = armor.TrimEnd(" ")
                armor = armor.TrimEnd(",")
                Form1.RichTextBox1.Text = "Weapons: " & weapon & ", " & "
Armor: " & armor & "
Random: " & sixSide.Roll & " TL2 Spare Parts " & "and " & fourside.Roll * 20 & " Rounds of ammo"
            End If
        ElseIf Loot = "Armory, Rebel" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            If LootTable.FiftyPercent = True Then
                randomchance = True

            End If
            weaponamount = sixSide.Roll
            While x < weaponamount
                weapon &= LootTable.Weapon(tenside.Roll + 2) & ", "

                x += 1
            End While
            weapon = weapon.TrimEnd(" ")
            weapon = weapon.TrimEnd(",")

            armoramount = fourside.Roll
            While z < armoramount
                armor &= LootTable.EnergyWeapon(eightside.Roll) & ", "

                z += 1
            End While
            armor = armor.TrimEnd(" ")
            armor = armor.TrimEnd(",")




            If randomchance = True Then
                lootstring = "Weapon: " & weapon & ", " & armor & "
Armor: " & sixSide.Roll & " Insurgent Combat Shell(s)" &
"Random: " & sixSide.Roll & " TL3 Spare Parts, and " & (sixSide.Roll * 20) & " Rounds of ammo"
            Else
                lootstring = "Weapon: " & weapon & "
Armor: " & sixSide.Roll & " Insurgent Combat Shell(s)" &
"Random: " & sixSide.Roll & " TL3 Spare Parts, and " & (sixSide.Roll * 20) & " Rounds of ammo"
            End If

            Form1.RichTextBox1.Text = lootstring
        ElseIf loot = "Camp, Small Raider" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            x = 0
            z = 0
            If LootTable.FiftyPercent = True Then
                ration = True
            End If
            If LootTable.FiftyPercent = True Then
                randomchance = True

            End If

            weaponamount = threeside.Roll
            While x < weaponamount
                weapon &= LootTable.Weapon(tenside.Roll + 2) & ", "

                x += 1
            End While
            weapon = weapon.TrimEnd(" ")
            weapon = weapon.TrimEnd(",")


            lootamount = fourside.Roll
            While z < lootamount
                randomloot &= LootTable.RandomLoot(twentyside.Roll + 3) & " "

                z += 1
            End While
            randomloot = randomloot.TrimEnd(" ")
            randomloot = randomloot.TrimEnd(",")


            lootstring = "Weapon(s): " & weapon & "
Random: " & randomloot & " " & LootTable.RandomLoot(twentyside.Roll + 10)

            If ration = True Then
                lootstring = lootstring & ", 20 rounds of ammo"
            End If
            If randomchance = True Then
                lootstring = lootstring & ", " & fourside.Roll & " Type A Power Cell"
            End If
            Form1.RichTextBox1.Text = lootstring

        ElseIf Loot = "Camp, Small Tribal" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            'If LootTable.TwentyFivePercent = True Then
            '    ration = True
            'End If
            'If LootTable.TwentyFivePercent = True Then
            '    randomchance = True

            'End If
            x = 0
            z = 0
            If LootTable.TwentyFivePercent = True Then
                ration = True
            End If
            If LootTable.TwentyFivePercent = True Then
                randomchance = True

            End If

            weaponamount = threeside.Roll
            While x < weaponamount
                weapon &= LootTable.Weapon(tenside.Roll) & ", "

                x += 1
            End While
            weapon = weapon.TrimEnd(" ")
            weapon = weapon.TrimEnd(",")


            lootamount = fourside.Roll
            While z < lootamount
                randomloot &= LootTable.RandomLoot(twentyside.Roll + 3) & " "

                z += 1
            End While
            randomloot = randomloot.TrimEnd(" ")
            randomloot = randomloot.TrimEnd(",")


            lootstring = "Weapon(s): " & weapon & "
Random: " & randomloot & " " & LootTable.RandomLoot(twentyside.Roll + 5)

            If ration = True Then
                lootstring = lootstring & ", 20 rounds of ammo"
            End If
            If randomchance = True Then
                lootstring = lootstring & ", " & fourside.Roll & " Type A Power Cell"
            End If
            Form1.RichTextBox1.Text = lootstring
        ElseIf Loot = "Enclave Plunder, TL1" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            If LootTable.TenPercent = True Then
                randomchance = True

            End If


            weaponamount = sixSide.Roll + sixSide.Roll
            While x < weaponamount
                weapon &= LootTable.Weapon(tenside.Roll) & ", "

                x += 1
            End While
            weapon = weapon.TrimEnd(" ")
            weapon = weapon.TrimEnd(",")

            armoramount = sixSide.Roll + sixSide.Roll
            While z < armoramount
                armor &= LootTable.Armor(eightside.Roll + 2) & ", "

                z += 1
            End While
            armor = armor.TrimEnd(" ")
            armor = armor.TrimEnd(",")
            z = 0
            lootamount = sixSide.Roll + sixSide.Roll
            While z < lootamount
                randomloot &= LootTable.RandomLoot(twentyside.Roll) & " "

                z += 1
            End While
            randomloot = randomloot.TrimEnd(" ")
            randomloot = randomloot.TrimEnd(",")
            '
            z = 0
            lootamount = sixSide.Roll
            While z < lootamount
                randomloot2 &= LootTable.RandomLoot(twentyside.Roll + 5) & " "

                z += 1
            End While
            randomloot2 = randomloot2.TrimEnd(" ")
            randomloot2 = randomloot2.TrimEnd(",")

            lootstring = "Weapon(s): " & weapon & "
Armor: " & armor & "
Random: " & randomloot & ", " & randomloot2 & ", " & fourside.Roll * 20 & " rounds of ammo, " & fourside.Roll & " Type A Power Cells, " & twentyside.Roll * 10 & " Rations"

            If randomchance = True Then
                lootstring = "Weapon(s): " & weapon & "
Armor: " & armor & "
Random: " & randomloot & ", " & randomloot2 & ", " & fourside.Roll * 20 & " rounds of ammo, " & fourside.Roll & " Type A Power Cells, " & LootTable.RareItem(hundred.Roll) & ", " & twentyside.Roll * 10 & " Rations"
            End If
            Form1.RichTextBox1.Text = lootstring
            x = 0
            z = 0
        ElseIf Loot = "Enclave Plunder, TL2" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            If LootTable.TwentyFivePercent = True Then
                randomchance = True

            End If


            weaponamount = sixSide.Roll + sixSide.Roll
            While x < weaponamount
                weapon &= LootTable.Weapon(sixSide.Roll + 8) & ", "

                x += 1
            End While
            weapon = weapon.TrimEnd(" ")
            weapon = weapon.TrimEnd(",")

            armoramount = sixSide.Roll + sixSide.Roll
            While z < armoramount
                armor &= LootTable.Armor(tenside.Roll + 4) & ", "

                z += 1
            End While
            armor = armor.TrimEnd(" ")
            armor = armor.TrimEnd(",")
            z = 0
            lootamount = sixSide.Roll + sixSide.Roll + sixSide.Roll
            While z < lootamount
                randomloot &= LootTable.RandomLoot(twentyside.Roll) & " "

                z += 1
            End While
            randomloot = randomloot.TrimEnd(" ")
            randomloot = randomloot.TrimEnd(",")
            '
            z = 0
            lootamount = sixSide.Roll
            While z < lootamount
                randomloot2 &= LootTable.RandomLoot(twentyside.Roll + 10) & " "

                z += 1
            End While
            randomloot2 = randomloot2.TrimEnd(" ")
            randomloot2 = randomloot2.TrimEnd(",")

            lootstring = "Weapon(s): " & weapon & "
Armor: " & armor & "
Random: " & randomloot & ", " & randomloot2 & ", " & (sixSide.Roll + sixSide.Roll + sixSide.Roll) * 20 & " rounds of ammo, " & (sixSide.Roll + sixSide.Roll) & " Type A Power Cells, " & twentyside.Roll * 10 & " Rations"


            If randomchance = True Then
                lootstring = "Weapon(s): " & weapon & "
Armor: " & armor & "
Random: " & randomloot & ", " & randomloot2 & ", " & (sixSide.Roll + sixSide.Roll + sixSide.Roll) * 20 & " rounds of ammo, " & (sixSide.Roll + sixSide.Roll) & " Type A Power Cells, " & LootTable.RareItem(hundred.Roll) & ", " & twentyside.Roll * 10 & " Rations"
            End If
            Form1.RichTextBox1.Text = lootstring
            x = 0
            z = 0
        ElseIf Loot = "Enclave Plunder, TL3" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            If LootTable.TwentyFivePercent = True Then
                randomchance = True

            End If


            weaponamount = sixSide.Roll + sixSide.Roll
            While x < weaponamount
                weapon &= LootTable.Weapon(sixSide.Roll + 8) & ", "

                x += 1
            End While
            weapon = weapon.TrimEnd(" ")
            weapon = weapon.TrimEnd(",")

            armoramount = sixSide.Roll + sixSide.Roll
            While z < armoramount
                armor &= LootTable.Armor(tenside.Roll + 4) & ", "

                z += 1
            End While
            armor = armor.TrimEnd(" ")
            armor = armor.TrimEnd(",")
            z = 0
            lootamount = sixSide.Roll + sixSide.Roll + sixSide.Roll
            While z < lootamount
                randomloot &= LootTable.RandomLoot(twentyside.Roll) & " "

                z += 1
            End While
            randomloot = randomloot.TrimEnd(" ")
            randomloot = randomloot.TrimEnd(",")
            '
            z = 0
            lootamount = sixSide.Roll
            While z < lootamount
                randomloot2 &= LootTable.RandomLoot(twentyside.Roll + 10) & " "

                z += 1
            End While
            randomloot2 = randomloot2.TrimEnd(" ")
            randomloot2 = randomloot2.TrimEnd(",")

            lootstring = "Weapon(s): " & weapon & "
Armor: " & armor & "
Random: " & randomloot & ", " & randomloot2 & ", " & (sixSide.Roll + sixSide.Roll + sixSide.Roll) * 20 & " rounds of ammo, " & (sixSide.Roll + sixSide.Roll) & " Type A Power Cells, " & tenside.Roll * 20 & " Rations"


            If randomchance = True Then
                lootstring = "Weapon(s): " & weapon & "
Armor: " & armor & "
Random: " & randomloot & ", " & randomloot2 & ", " & (sixSide.Roll + sixSide.Roll + sixSide.Roll) * 20 & " rounds of ammo, " & (sixSide.Roll + sixSide.Roll) & " Type A Power Cells, " & LootTable.RareItem(hundred.Roll) & ", " & tenside.Roll * 20 & " Rations"
            End If
            Form1.RichTextBox1.Text = lootstring
            x = 0
            z = 0
        ElseIf Loot = "Enclave Plunder, TL4" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0



            weaponamount = sixSide.Roll + sixSide.Roll
            While x < weaponamount
                weapon &= LootTable.Weapon(sixSide.Roll + 14) & ", "

                x += 1
            End While
            weapon = weapon.TrimEnd(" ")
            weapon = weapon.TrimEnd(",")

            armoramount = sixSide.Roll + sixSide.Roll
            While z < armoramount
                armor &= LootTable.Armor(tenside.Roll + 10) & ", "

                z += 1
            End While
            armor = armor.TrimEnd(" ")
            armor = armor.TrimEnd(",")
            z = 0
            lootamount = sixSide.Roll + sixSide.Roll + sixSide.Roll
            While z < lootamount
                randomloot &= LootTable.RandomLoot(twentyside.Roll + 5) & " "

                z += 1
            End While
            randomloot = randomloot.TrimEnd(" ")
            randomloot = randomloot.TrimEnd(",")
            '
            z = 0
            lootamount = sixSide.Roll
            While z < lootamount
                randomloot2 &= LootTable.RandomLoot(twentyside.Roll + 15) & " "

                z += 1
            End While
            randomloot2 = randomloot2.TrimEnd(" ")
            randomloot2 = randomloot2.TrimEnd(",")

            z = 0

            rarecount = fourside.Roll
            While z < rarecount
                rareitems &= LootTable.RareItem(hundred.Roll) & " "

                z += 1
            End While
            rareitems = rareitems.TrimEnd(" ")
            rareitems = rareitems.TrimEnd(",")

            lootstring = "Weapon(s): " & weapon & "
Armor: " & armor & "
Random: " & randomloot & ", " & randomloot2 & ", " & rareitems & ", " & (sixSide.Roll + sixSide.Roll + sixSide.Roll) * 20 & " rounds of ammo, " & (sixSide.Roll + sixSide.Roll) & " Type A Power Cells, " & ((twentyside.Roll + twentyside.Roll) * 20) & " Rations"



            Form1.RichTextBox1.Text = lootstring
        ElseIf Loot = "Medical Cache, Major" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            lootstring = (tenside.Roll * 10) & " Stims, " & fourside.Roll & " Medkit(s)"
            Form1.RichTextBox1.Text = lootstring

        ElseIf Loot = "Medical Cache, Minor" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            If LootTable.FiftyPercent = True Then
                randomchance = True
            End If

            lootstring = sixSide.Roll & " Stims"

            If randomchance = True Then
                lootstring = lootstring & ", 1 Medkit"
            End If
            Form1.RichTextBox1.Text = lootstring
        ElseIf Loot = "Ruin, Large Structure" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            lootamount = sixSide.Roll + sixSide.Roll + sixSide.Roll + sixSide.Roll + sixSide.Roll
            While z < lootamount
                randomloot &= LootTable.RandomLoot(twentyside.Roll) & " "

                z += 1
            End While
            randomloot = randomloot.TrimEnd(" ")
            randomloot = randomloot.TrimEnd(",")

            z = 0
            lootamount = tenside.Roll
            While z < lootamount
                randomloot2 &= LootTable.RandomLoot(twentyside.Roll + 10) & " "

                z += 1
            End While
            randomloot2 = randomloot2.TrimEnd(" ")
            randomloot2 = randomloot2.TrimEnd(",")

            z = 0

            rarecount = fourside.Roll - 1

            If rarecount = 0 Then
            Else
                While z < rarecount
                    rareitems &= LootTable.RareItem(hundred.Roll) & " "

                    z += 1
                End While
                rareitems = rareitems.TrimEnd(" ")
                rareitems = rareitems.TrimEnd(",")
            End If
            If rareitems = "" Then
                lootstring = "Random: " & randomloot & ", " & randomloot2 & ", " & (sixSide.Roll + sixSide.Roll) & " TL4 Spare Parts"
            Else
                lootstring = "Random: " & randomloot & ", " & randomloot2 & ", " & rareitems & ", " & (sixSide.Roll + sixSide.Roll) & " TL4 Spare Parts"
            End If
            Form1.RichTextBox1.Text = lootstring
        ElseIf Loot = "Ruin, Single Building" Then

            If LootTable.TwentyPercent = True Then
                randomchance = True
            End If
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            lootamount = sixSide.Roll + sixSide.Roll + sixSide.Roll
            While z < lootamount
                randomloot &= LootTable.RandomLoot(twentyside.Roll) & " "

                z += 1
            End While
            randomloot = randomloot.TrimEnd(" ")
            randomloot = randomloot.TrimEnd(",")

            z = 0
            lootamount = fourside.Roll
            While z < lootamount
                randomloot2 &= LootTable.RandomLoot(twentyside.Roll + 10) & " "

                z += 1
            End While
            randomloot2 = randomloot2.TrimEnd(" ")
            randomloot2 = randomloot2.TrimEnd(",")

            z = 0


            If randomchance = True Then

                lootstring = "Random: " & randomloot & ", " & randomloot2 & ", " & LootTable.RandomLoot(twentyside.Roll + 20) & ", " & (sixSide.Roll) & " TL4 Spare Parts"
            Else
                lootstring = "Random: " & randomloot & ", " & randomloot2 & ", " & (sixSide.Roll) & " TL4 Spare Parts"
            End If
            Form1.RichTextBox1.Text = lootstring
            z = 0
            x = 0
        ElseIf Loot = "Survival Cache, Enclave" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            If LootTable.FiftyPercent = True Then
                randomchance = True

            End If
            If LootTable.FiftyPercent = True Then
                ration = True
            End If

            lootamount = sixSide.Roll
            While z < lootamount
                randomloot &= LootTable.RandomLoot(twentyside.Roll) & " "

                z += 1
            End While
            randomloot = randomloot.TrimEnd(" ")
            randomloot = randomloot.TrimEnd(",")

            z = 0

            lootstring = "Random: " & tenside.Roll & " Old Terran Rations, " & randomloot
            If randomchance = True Then
                lootstring = lootstring & ", " & fourside.Roll * 20 & " rounds of ammo"
            End If
            If ration = True Then
                lootstring = lootstring & ", " & sixSide.Roll & " Type A Power Cells"
            End If

            Form1.RichTextBox1.Text = lootstring
            z = 0
        ElseIf Loot = "Survival Cache, Ancient" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            lootamount = sixSide.Roll
            While z < lootamount
                randomloot &= LootTable.UncommonItem(twentyside.Roll) & " "

                z += 1
            End While
            randomloot = randomloot.TrimEnd(" ")
            randomloot = randomloot.TrimEnd(",")

            z = 0

            lootstring = "Random: " & (eightside.Roll + eightside.Roll + eightside.Roll) & " Old Terran Rations, " & randomloot & ", " & sixSide.Roll + 4 & " Type A Power Cells"


            Form1.RichTextBox1.Text = lootstring
            z = 0
        ElseIf Loot = "Tech Cache, Major" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            If LootTable.FiftyPercent = True Then
                randomchance = True

            End If
            If LootTable.FiftyPercent = True Then
                ration = True
            End If

            lootstring = "Random: " & tenside.Roll + 10 & " of each TL from 3 to 5"
            If ration = True Then
                lootstring = lootstring & ", Metatool"
            End If

            If randomchance = True Then
                lootstring = lootstring & ", " & LootTable.RareItem(hundred.Roll)

            End If
            Form1.RichTextBox1.Text = lootstring
            z = 0
        ElseIf Loot = "Tech Cache, Minor" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            If LootTable.FiftyPercent = True Then
                randomchance = True

            End If
            lootstring = "Random: " & tenside.Roll + 10 & " of TL" & fourside.Roll + 1 & " spare parts"

            If randomchance = True Then
                lootstring = lootstring & ", " & LootTable.RandomLoot(twentyside.Roll + 10)
            End If

            Form1.RichTextBox1.Text = lootstring
            z = 0

        ElseIf Loot = "Trader Caravan" Then
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            If LootTable.TwentyFivePercent = True Then
                randomchance = True

            End If
            weaponamount = fourside.Roll
            While x < weaponamount
                weapon &= LootTable.Weapon(sixSide.Roll + 9) & ", "

                x += 1
            End While
            weapon = weapon.TrimEnd(" ")
            weapon = weapon.TrimEnd(",")

            armoramount = fourside.Roll
            While z < armoramount
                armor &= LootTable.Armor(tenside.Roll + 4) & ", "

                z += 1
            End While
            armor = armor.TrimEnd(" ")
            armor = armor.TrimEnd(",")
            z = 0


            lootstring = "Weapons: " & weapon & "
Armor: " & armor & "
Random: " & sixSide.Roll * 20 & " rounds of ammo, " & fourside.Roll & " Type A Power Cells, " & LootTable.RandomLoot(twentyside.Roll + 10) & ", " & LootTable.RandomLoot(twentyside.Roll + 10)

            If randomchance = True Then
                lootstring = lootstring & ", " & LootTable.RareItem(hundred.Roll)
            End If
            Form1.RichTextBox1.Text = lootstring

        ElseIf Loot = "Workshop, Old Terran" Then


            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0
            If LootTable.SeventyFivePercent = True Then
                randomchance = True
            End If

            If LootTable.TwentyFivePercent = True Then
                ration = True
            End If


            lootstring = "Random: " & tenside.Roll + 15 & " TL4 Spare Parts, " & eightside.Roll & " TL5 Spare Parts, " & LootTable.RandomLoot(twentyside.Roll + 15) & " (BROKEN), " & LootTable.RandomLoot(twentyside.Roll + 15) & " (BROKEN)"

            If randomchance = True Then
                lootstring = lootstring & ", TL4 Toolkit"
            End If
            If ration = True Then
                lootstring = lootstring & ", TL5 Toolkit"
            End If
            Form1.RichTextBox1.Text = lootstring
            z = 0
            randomloot = ""
            rareitems = ""
            weapon = ""
            randomloot2 = ""
            x = 0

        ElseIf Loot = "Workshop, Scrounger" Then
            If LootTable.SeventyFivePercent = True Then
                randomchance = True
            End If

            If LootTable.TwentyFivePercent = True Then
                ration = True
            End If


            lootstring = "Random: TL2 Toolkit, " & tenside.Roll + 15 & " TL2 Spare Parts, " & tenside.Roll + 5 & " TL3 Spare Parts, " & sixSide.Roll & " TL4 Spare Parts" & LootTable.RandomLoot(twentyside.Roll) & " (BROKEN), " & LootTable.RandomLoot(twentyside.Roll) & " (BROKEN)"
            If randomchance = True Then
                lootstring = lootstring & ", TL3 Toolkit"
            End If
            If ration = True Then
                lootstring = lootstring & ", TL4 Toolkit"
            End If

            Form1.RichTextBox1.Text = lootstring
        End If

    End Function

End Class