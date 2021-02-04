Public Class LootTable
    Shared lootWeapon As String
    Shared lootArmor As String
    Shared lootEnergyWeapon As String
    Shared lootRandom As String
    Shared lootCommonItem As String
    Shared lootUncommonItem As String
    Shared lootRareItem As String
    Public Shared Function Weapon(Die As Integer, Optional amount As Integer = 1)
        If Die = 1 Then
            LootTable.lootWeapon = "Knife"
        ElseIf Die = 2 Then
            LootTable.lootWeapon = "Club"
        ElseIf Die = 3 Then
            LootTable.lootWeapon = "Spear"
        ElseIf Die = 4 Then
            LootTable.lootWeapon = "Spear"
        ElseIf Die = 5 Then
            LootTable.lootWeapon = "Sword"
        ElseIf Die = 6 Then
            LootTable.lootWeapon = "Axe"
        ElseIf Die = 7 Then
            LootTable.lootWeapon = "Breechloading Rifle"
        ElseIf Die = 8 Then
            LootTable.lootWeapon = "Spear"
        ElseIf Die = 9 Then
            LootTable.lootWeapon = "Sword"
        ElseIf Die = 10 Then
            LootTable.lootWeapon = "Revolver"
        ElseIf Die = 11 Then
            LootTable.lootWeapon = "Revolver"
        ElseIf Die = 12 Then
            LootTable.lootWeapon = "Semi-Auto Pistol"
        ElseIf Die = 13 Then
            LootTable.lootWeapon = "Semi-Auto Rifle"
        ElseIf Die = 14 Then
            LootTable.lootWeapon = "Shotgun"
        ElseIf Die = 15 Then
            LootTable.lootWeapon = "Monoblade"
        ElseIf Die = 16 Then
            LootTable.lootWeapon = "Submachine Gun"
        ElseIf Die = 17 Then
            LootTable.lootWeapon = "Combat Rifle"
        ElseIf Die = 18 Then
            LootTable.lootWeapon = "Monoblade"
        ElseIf Die = 19 Then
            LootTable.lootWeapon = "Combat Rifle"
        ElseIf Die = 20 Then
            LootTable.lootWeapon = "Combat Shotgun"
        ElseIf Die = 21 Then
            LootTable.lootWeapon = "Huge Monoblade"
        ElseIf Die = 22 Then
            LootTable.lootWeapon = "Combat Rifle"
        ElseIf Die = 23 Then
            LootTable.lootWeapon = "Mag Pistol"
        ElseIf Die = 24 Then
            LootTable.lootWeapon = "Mag Pistol"
        ElseIf Die = 25 Then
            LootTable.lootWeapon = "Mag Rifle"
        ElseIf Die = 26 Then
            LootTable.lootWeapon = "Mag Rifle"
        End If
        Return LootTable.lootWeapon
    End Function
    Public Shared Function Armor(Die As Integer)
        If Die = 1 Then
            LootTable.lootArmor = "No Armor"
        ElseIf Die = 2 Then
            LootTable.lootArmor = "No Armor"
        ElseIf Die = 3 Then
            LootTable.lootArmor = "Shield"
        ElseIf Die = 4 Then
            LootTable.lootArmor = "Shield"
        ElseIf Die = 5 Then
            LootTable.lootArmor = "Hide Armor"
        ElseIf Die = 6 Then
            LootTable.lootArmor = "Hide Armor/Shield"
        ElseIf Die = 7 Then
            LootTable.lootArmor = "Hide Armor/Shield"
        ElseIf Die = 8 Then
            LootTable.lootArmor = "Old Terran"
        ElseIf Die = 9 Then
            LootTable.lootArmor = "Old Terran Clothing/Shield"
        ElseIf Die = 10 Then
            LootTable.lootArmor = "Scrap Mail"
        ElseIf Die = 11 Then
            LootTable.lootArmor = "Scrap Mail/Shield"
        ElseIf Die = 12 Then
            LootTable.lootArmor = "Scrap Mail/Shield"
        ElseIf Die = 13 Then
            LootTable.lootArmor = "Harmony Armor"
        ElseIf Die = 14 Then
            LootTable.lootArmor = "Harmony Armor"
        ElseIf Die = 15 Then
            LootTable.lootArmor = "Harmony Armor/Shield"
        ElseIf Die = 16 Then
            LootTable.lootArmor = "Terran Explorer Suit"
        ElseIf Die = 17 Then
            LootTable.lootArmor = "Scrap Plate"
        ElseIf Die = 18 Then
            LootTable.lootArmor = "Scrap Plate/Shield"
        ElseIf Die = 19 Then
            LootTable.lootArmor = "Insurgent Combat Shell"
        ElseIf Die = 20 Then
            LootTable.lootArmor = "Insurgent Combat Shell"
        ElseIf Die = 21 Then
            LootTable.lootArmor = "Insurgent Combat Shell"
        ElseIf Die = 22 Then
            LootTable.lootArmor = "Powered Armor"
        ElseIf Die = 23 Then
            LootTable.lootArmor = "Powered Armor"
        ElseIf Die = 24 Then
            LootTable.lootArmor = "Executive Protection Field"
        ElseIf Die = 25 Then
            LootTable.lootArmor = "Executive Protection Field"
        ElseIf Die = 26 Then
            LootTable.lootArmor = "Storm Plate"
        End If
        Return LootTable.lootArmor
    End Function
    Public Shared Function EnergyWeapon(Die As Integer)
        If Die = 1 Then
            LootTable.lootEnergyWeapon = "Laser Pistol"
        ElseIf Die = 2 Then
            LootTable.lootEnergyWeapon = "Laser Pistol"
        ElseIf Die = 3 Then
            LootTable.lootEnergyWeapon = "Laser Pistol"
        ElseIf Die = 4 Then
            LootTable.lootEnergyWeapon = "Laser Pistol"
        ElseIf Die = 5 Then
            LootTable.lootEnergyWeapon = "Laser Rifle"
        ElseIf Die = 6 Then
            LootTable.lootEnergyWeapon = "Laser Rifle"
        ElseIf Die = 7 Then
            LootTable.lootEnergyWeapon = "Laser Rifle"
        ElseIf Die = 8 Then
            LootTable.lootEnergyWeapon = "Thermal Pistol"
        ElseIf Die = 9 Then
            LootTable.lootEnergyWeapon = "Thermal Pistol"
        ElseIf Die = 10 Then
            LootTable.lootEnergyWeapon = "Plasma Projector"
        ElseIf Die = 11 Then
            LootTable.lootEnergyWeapon = "Plasma Projector"
        ElseIf Die = 12 Then
            LootTable.lootEnergyWeapon = "Shear Rifle"
        ElseIf Die = 13 Then
            LootTable.lootEnergyWeapon = "Shear Rifle"
        ElseIf Die = 14 Then
            LootTable.lootEnergyWeapon = "Neutron Blaster"
        End If
        Return LootTable.lootEnergyWeapon
    End Function
    Public Shared Function RandomLoot(Die As Integer)
        Dim commonitem = New Integer() {6, 7, 8, 9, 10, 11, 12, 13, 14}
        Dim twocommonitems = New Integer() {15, 16, 17, 18, 19}
        Dim uncommonitem = New Integer() {20, 21, 22, 23, 24, 25, 26}
        Dim twouncommonitems = New Integer() {27, 28, 29}
        Dim rareitem = New Integer() {30, 31, 32, 33, 34}
        Dim onehundredside As New Die(100)

        If Die = 1 Or Die = 2 Or Die = 3 Or Die = 4 Or Die = 5 Then
            LootTable.lootRandom = "Nothing, "
        ElseIf commonitem.Contains(Die) Then

            LootTable.lootRandom = CommonItems(onehundredside.Roll)
        ElseIf twocommonitems.Contains(Die) Then
            LootTable.lootRandom = CommonItems(onehundredside.Roll) & ", " & CommonItems(onehundredside.Roll)
        ElseIf uncommonitem.Contains(Die) Then
            'MsgBox(Die)
            'MsgBox(LootTable.lootRandom = uncommonitem(onehundredside.Roll))
            LootTable.lootRandom = LootTable.UncommonItem(onehundredside.Roll)
        ElseIf twouncommonitems.Contains(Die) Then
            LootTable.lootRandom = LootTable.UncommonItem(onehundredside.Roll) & ", " & LootTable.UncommonItem(onehundredside.Roll)
        ElseIf rareitem.Contains(Die) Then
            LootTable.lootRandom = LootTable.RareItem(onehundredside.Roll)
        Else

        End If
        Return LootTable.lootRandom
    End Function

    Public Shared Function FiftyPercent()
        Dim onehundredside As New Die(100)
        Dim fifty As Boolean = False
        If onehundredside.Roll >= 50 Then
            fifty = True
        End If
        Return fifty
    End Function
    Public Shared Function TwentyFivePercent()
        Dim onehundredside As New Die(100)
        Dim twentyfive As Boolean = False
        If onehundredside.Roll <= 25 Then
            twentyfive = True

        End If
        Return twentyfive
    End Function

    Public Shared Function SeventyFivePercent()
        Dim onehundredside As New Die(100)
        Dim seventyfive As Boolean = False
        If onehundredside.Roll <= 75 Then
            seventyfive = True

        End If
        Return seventyfive
    End Function

    Public Shared Function TwentyPercent()
        Dim onehundredside As New Die(100)
        Dim twenty As Boolean = False
        If onehundredside.Roll <= 20 Then
            twenty = True

        End If
        Return twenty
    End Function
    Public Shared Function TenPercent()
        Dim onehundredside As New Die(100)
        Dim ten As Boolean = False
        If onehundredside.Roll <= 10 Then
            ten = True

        End If
        Return ten
    End Function
    Public Shared Function CommonItems(Die As Integer)
        'MsgBox(Die & "common")
        Dim commonitem As String
        Dim onetofive = New Integer() {1, 2, 3, 4, 5}
        Dim sixtoten = New Integer() {6, 7, 8, 9, 10}
        Dim eleventofifteen = New Integer() {11, 12, 13, 14, 15}
        Dim sixteentoeighteen = New Integer() {16, 17, 18}
        Dim ninteentotwentyone = New Integer() {19, 20, 21}
        Dim twentytwototwentythree = New Integer() {22, 23}
        Dim twentyfourtotwentysix = New Integer() {24, 25, 26}
        Dim twentyseventothirtyone = New Integer() {27, 28, 29, 30, 31}
        Dim thirtytwotothirtythree = New Integer() {32, 33}
        Dim thirtyfourtothirtyfive = New Integer() {34, 35}
        Dim thirtysixtothirtynine = New Integer() {36, 37, 38, 39}
        Dim fourtytofourtyfour = New Integer() {40, 41, 42, 43, 44}
        Dim fourtyfivetofourtyseven = New Integer() {45, 46, 47}
        Dim fourtyeighttofifty = New Integer() {48, 49, 50}
        Dim fiftyonetofiftyfive = New Integer() {51, 52, 53, 54, 55}
        Dim fiftysixtofiftyeight = New Integer() {56, 57, 58}
        Dim fiftyninetosixtytwo = New Integer() {59, 60, 61, 62}
        Dim sixtythreetosixtyfive = New Integer() {63, 64, 65}
        Dim sixtysixtoseventy = New Integer() {66, 67, 68, 69, 70}
        Dim seventyonetoseventyfive = New Integer() {71, 72, 73, 74, 75}
        Dim seventysixtoseventyseven = New Integer() {76, 77}
        Dim seventyeighttoeighty = New Integer() {78, 79, 80}
        Dim eightyonetoeightyfour = New Integer() {81, 82, 83, 84}
        Dim eightyfivetoeightysix = New Integer() {85, 86}
        Dim eightyseventoeightyeight = New Integer() {87, 88}
        Dim eightyninetoninety = New Integer() {89, 90}
        Dim ninetyonetoninetyfive = New Integer() {91, 92, 93, 94, 95}
        Dim ninetysixtoonehundred = New Integer() {96, 97, 98, 99, 100}
        Dim fourside As New Die(4)
        Dim twosided As New Die(2)
        Dim sixsided As New Die(6)
        Dim tenside As New Die(10)
        If onetofive.Contains(Die) Then
            LootTable.lootCommonItem = "Ammunition, 20 Rounds"
        ElseIf sixtoten.Contains(Die) Then
            LootTable.lootCommonItem = "Backpack, TL1"
        ElseIf eleventofifteen.Contains(Die) Then
            LootTable.lootCommonItem = "Bedroll, TL1"
        ElseIf sixteentoeighteen.Contains(Die) Then
            LootTable.lootCommonItem = "Binoculars, TL2"
        ElseIf ninteentotwentyone.Contains(Die) Then
            LootTable.lootCommonItem = "Bonding Tape"
        ElseIf twentytwototwentythree.Contains(Die) Then
            LootTable.lootCommonItem = "Climbing Kit"
        ElseIf twentyfourtotwentysix.Contains(Die) Then
            LootTable.lootCommonItem = "Compass, Magnetic"
        ElseIf twentyseventothirtyone.Contains(Die) Then
            LootTable.lootCommonItem = "Crowbar"
        ElseIf thirtytwotothirtythree.Contains(Die) Then
            LootTable.lootCommonItem = "Firebox"
        ElseIf thirtyfourtothirtyfive.Contains(Die) Then
            LootTable.lootCommonItem = "Firestarter, TL1"
        ElseIf thirtysixtothirtynine.Contains(Die) Then

            LootTable.lootCommonItem = fourside.Roll & " Grenades"
        ElseIf fourtytofourtyfour.Contains(Die) Then
            LootTable.lootCommonItem = "Glowbug"
        ElseIf fourtyfivetofourtyseven.Contains(Die) Then
            LootTable.lootCommonItem = "Lantern"
        ElseIf fourtyeighttofifty.Contains(Die) Then

            LootTable.lootCommonItem = fourside.Roll & " Oil Flasks"
        ElseIf fiftyonetofiftyfive.Contains(Die) Then
            LootTable.lootCommonItem = "Power Cell, Type A"
        ElseIf fiftysixtofiftyeight.Contains(Die) Then
            Dim foursided As New Die(4)
            LootTable.lootCommonItem = fourside.Roll & " Rations, Dirty"
        ElseIf fiftyninetosixtytwo.Contains(Die) Then
            Dim foursided As New Die(4)
            LootTable.lootCommonItem = fourside.Roll & " Rations, Normal"
        ElseIf sixtythreetosixtyfive.Contains(Die) Then
            LootTable.lootCommonItem = "Rope, 20m, TL1"
        ElseIf sixtysixtoseventy.Contains(Die) Then

            LootTable.lootCommonItem = sixsided.Roll & " TL" & twosided.Roll & " Spare Parts"
        ElseIf seventyonetoseventyfive.Contains(Die) Then

            LootTable.lootCommonItem = sixsided.Roll & " Stims"
        ElseIf seventysixtoseventyseven.Contains(Die) Then
            LootTable.lootCommonItem = "Tent, TL1"
        ElseIf seventyeighttoeighty.Contains(Die) Then
            LootTable.lootCommonItem = "Toolkit, TL1"
        ElseIf eightyonetoeightyfour.Contains(Die) Then
            LootTable.lootCommonItem = "Toolkit, TL2"
        ElseIf eightyfivetoeightysix.Contains(Die) Then
            LootTable.lootCommonItem = "Water Filter"
        ElseIf eightyseventoeightyeight.Contains(Die) Then
            LootTable.lootCommonItem = "Thermal Flare"
        ElseIf eightyninetoninety.Contains(Die) Then
            LootTable.lootCommonItem = "Utility Tarp"
        ElseIf ninetyonetoninetyfive.Contains(Die) Then

            LootTable.lootCommonItem = Weapon(tenside.Roll + 2)
        ElseIf ninetysixtoonehundred.Contains(Die) Then
            LootTable.lootCommonItem = LootTable.UncommonItem(Die)

        End If
        Return LootTable.lootCommonItem
    End Function

    Public Shared Function UncommonItem(Die As Integer)
        'MsgBox(Die & "Uncommon")
        'Dim UncommonItem As String
        Dim t15 = New Integer() {1, 2, 3, 4, 5}
        Dim t68 = New Integer() {6, 7, 8}
        Dim t913 = New Integer() {9, 10, 11, 12, 13}
        Dim t1416 = New Integer() {14, 15, 16}
        Dim t1719 = New Integer() {17, 18, 19}
        Dim t2024 = New Integer() {20, 21, 22, 23, 24}
        Dim t2526 = New Integer() {25, 26}
        Dim t2728 = New Integer() {27, 28}
        Dim t2936 = New Integer() {29, 30, 31, 32, 33, 34, 35, 36}
        Dim t3738 = New Integer() {37, 38}
        Dim t3943 = New Integer() {39, 40, 41, 42, 43}
        Dim t4448 = New Integer() {44, 45, 46, 47, 48}
        Dim t4950 = New Integer() {49, 50}
        Dim t5155 = New Integer() {51, 52, 53, 54, 55}
        Dim t5660 = New Integer() {56, 57, 58, 59, 60}
        Dim t6164 = New Integer() {61, 62, 63, 64}
        Dim t6566 = New Integer() {65, 66}
        Dim t6768 = New Integer() {67, 68}
        Dim t6973 = New Integer() {69, 70, 71, 72, 73}
        Dim t7478 = New Integer() {74, 75, 76, 77, 78}
        Dim t7980 = New Integer() {79, 80}
        Dim t8183 = New Integer() {81, 82, 83}
        Dim t8487 = New Integer() {84, 85, 86, 87}
        Dim t88 = New Integer() {88}
        Dim t89 = New Integer() {89}
        Dim t9092 = New Integer() {90, 91, 92}
        Dim t9397 = New Integer() {93, 94, 95, 96, 97}
        Dim fourside As New Die(4)
        Dim threeside As New Die(3)
        Dim sixside As New Die(6)
        Dim tenside As New Die(10)
        Dim eightside As New Die(8)
        If t15.Contains(Die) Then


            LootTable.lootUncommonItem = "+1 Blueprints, TL" & (threeside.Roll() + 1)
        ElseIf t68.Contains(Die) Then
            LootTable.lootUncommonItem = "Binoculars, TL4"
        ElseIf t913.Contains(Die) Then
            LootTable.lootUncommonItem = "Backpack, TL4"
        ElseIf t1416.Contains(Die) Then
            LootTable.lootUncommonItem = "Bedroll, TL4"
        ElseIf t1719.Contains(Die) Then
            LootTable.lootUncommonItem = "Compad"
        ElseIf t2024.Contains(Die) Then
            LootTable.lootUncommonItem = "Dataslab"
        ElseIf t2526.Contains(Die) Then
            LootTable.lootUncommonItem = "Geiger Counter"
        ElseIf t2728.Contains(Die) Then
            LootTable.lootUncommonItem = "Generator, Solar"
        ElseIf t2936.Contains(Die) Then
            LootTable.lootUncommonItem = (fourside.Roll + fourside.Roll) & " Stims"
        ElseIf t3738.Contains(Die) Then
            LootTable.lootUncommonItem = "Link, Prostethic"
        ElseIf t3943.Contains(Die) Then
            LootTable.lootUncommonItem = "Medkit"
        ElseIf t4448.Contains(Die) Then
            LootTable.lootUncommonItem = "Metatool"
        ElseIf t4950.Contains(Die) Then
            LootTable.lootUncommonItem = "Navcomp"
        ElseIf t5155.Contains(Die) Then
            LootTable.lootUncommonItem = "Power Cell, A+"
        ElseIf t5660.Contains(Die) Then
            LootTable.lootUncommonItem = "Power Cell, B"
        ElseIf t6164.Contains(Die) Then
            LootTable.lootUncommonItem = sixside.Roll & " Rations, Old Terran"
        ElseIf t6566.Contains(Die) Then
            LootTable.lootUncommonItem = "Rope, 20m, TL4"
        ElseIf t6768.Contains(Die) Then
            LootTable.lootUncommonItem = "Solar Cell"
        ElseIf t6973.Contains(Die) Then
            LootTable.lootUncommonItem = sixside.Roll & " TL3 Spare Parts"
        ElseIf t7478.Contains(Die) Then
            LootTable.lootUncommonItem = sixside.Roll & " TL4 Spare Parts"
        ElseIf t7980.Contains(Die) Then
            LootTable.lootUncommonItem = "Tent, TL4"
        ElseIf t8183.Contains(Die) Then
            LootTable.lootUncommonItem = "Toolkit, TL3"
        ElseIf t8487.Contains(Die) Then
            LootTable.lootUncommonItem = "Toolkit, TL4"
        ElseIf t88.Contains(Die) Then
            LootTable.lootUncommonItem = "Toxin Detector"
        ElseIf t89.Contains(Die) Then
            LootTable.lootUncommonItem = "Vacc Suit, Pretech"
        ElseIf t9092.Contains(Die) Then
            LootTable.lootUncommonItem = Weapon((tenside.Roll + 10))
        ElseIf t9397.Contains(Die) Then
            LootTable.lootUncommonItem = EnergyWeapon(eightside.Roll)

        Else
            LootTable.lootUncommonItem = RareItem(Die)
            'LootTable.lootUncommonItem = "CAP TEST"
        End If
        Return LootTable.lootUncommonItem
    End Function

    Public Shared Function RareItem(Die As Integer)
        'MsgBox(Die & "Rare")
        Dim fourside As New Die(4)
        Dim twentyside As New Die(20)
        Dim sixside As New Die(6)
        Dim tenside As New Die(10)
        Dim eightside As New Die(8)
        Dim t13 = New Integer() {1, 2, 3}
        Dim t46 = New Integer() {4, 5, 6}
        Dim t79 = New Integer() {7, 8, 9}
        Dim t1015 = New Integer() {10, 11, 12, 13, 14, 15}
        Dim t1617 = New Integer() {16, 17}
        Dim t1819 = New Integer() {18, 19}
        Dim t2022 = New Integer() {20, 21, 22}
        Dim t23 = New Integer() {23}
        Dim t2429 = New Integer() {24, 25, 26, 27, 28, 29}
        Dim t3045 = New Integer() {30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45}
        Dim t4665 = New Integer() {46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65}
        Dim t6670 = New Integer() {66, 67, 68, 69, 70}
        Dim t71 = New Integer() {71}
        Dim t7274 = New Integer() {72, 73, 74}
        Dim t7576 = New Integer() {75, 76}
        Dim t77 = New Integer() {77}
        Dim t78 = New Integer() {78}
        Dim t7980 = New Integer() {79, 80}
        Dim t8183 = New Integer() {81, 82, 83}
        Dim t8489 = New Integer() {84, 85, 86, 87, 88, 89}
        Dim t9095 = New Integer() {90, 91, 92, 93, 94, 95}
        Dim t96100 = New Integer() {96, 97, 98, 99, 100}

        If t13.Contains(Die) Then
            LootTable.lootRareItem = "+2 Blueprints, TL3"
        ElseIf t46.Contains(Die) Then
            LootTable.lootRareItem = "+2 Blueprints, TL4"
        ElseIf t79.Contains(Die) Then
            LootTable.lootRareItem = "+2 Blueprints, TL5"
        ElseIf t1015.Contains(Die) Then
            LootTable.lootRareItem = "+3 Blueprint, TL" & (fourside.Roll + 1)
        ElseIf t1617.Contains(Die) Then
            LootTable.lootRareItem = "+4 Blueprint, TL4"
        ElseIf t1819.Contains(Die) Then
            LootTable.lootRareItem = "+4 Blueprint, TL5"
        ElseIf t2022.Contains(Die) Then
            LootTable.lootRareItem = "Broadcast Power Mod"
        ElseIf t23.Contains(Die) Then
            LootTable.lootRareItem = "Generator, Nanofusion"
        ElseIf t2429.Contains(Die) Then
            LootTable.lootRareItem = "Power Cell, B+"
        ElseIf t3045.Contains(Die) Then
            LootTable.lootRareItem = twentyside.Roll & " TL4 Spare Parts"
        ElseIf t4665.Contains(Die) Then
            LootTable.lootRareItem = sixside.Roll & " TL5 Spare Parts"
        ElseIf t6670.Contains(Die) Then
            LootTable.lootRareItem = "Toolkit, TL5"
        ElseIf t71.Contains(Die) Then
            LootTable.lootRareItem = tenside.Roll & " Rage stims"
        ElseIf t7274.Contains(Die) Then
            LootTable.lootRareItem = tenside.Roll & " Purge Stims"
        ElseIf t7576.Contains(Die) Then
            LootTable.lootRareItem = "Microfac"
        ElseIf t77.Contains(Die) Then
            LootTable.lootRareItem = "Portable Expert System"
        ElseIf t78.Contains(Die) Then
            LootTable.lootRareItem = "Invasive Crosslink"
        ElseIf t7980.Contains(Die) Then
            LootTable.lootRareItem = "Neural Patterning Web"
        ElseIf t8183.Contains(Die) Then
            LootTable.lootRareItem = "Bot Override Tag"
        ElseIf t8489.Contains(Die) Then
            LootTable.lootRareItem = LootTable.Weapon(tenside.Roll + 16)
        ElseIf t9095.Contains(Die) Then
            LootTable.lootRareItem = LootTable.EnergyWeapon(sixside.Roll + 8)
        Else
            LootTable.lootRareItem = LootTable.Armor(eightside.Roll + 18)

        End If
        Return LootTable.lootRareItem
    End Function


End Class
