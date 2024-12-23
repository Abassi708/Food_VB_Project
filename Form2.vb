Public Class Form2

    Const Price_BottleWater As Decimal = 2.5
    Const Price_cheeseSandwich As Decimal = 7.6
    Const Price_ChikenSalad As Decimal = 6.5
    Const Price_ChikenSandwich As Decimal = 14.2
    Const Price_ChocolateMilkShake As Decimal = 10.1
    Const Price_ChocolateMuffin As Decimal = 9.6
    Const Price_Coffee As Decimal = 7.6
    Const Price_Cola As Decimal = 6.2
    Const Price_FishSandwich As Decimal = 17.0
    Const Price_Fries As Decimal = 5.5
    Const Price_Hamburger As Decimal = 15.6
    Const Price_HashBrown As Decimal = 11.5
    Const Price_OnionRings As Decimal = 2.3
    Const Price_Orange As Decimal = 9.5
    Const Price_Pancakes As Decimal = 10.5
    Const Price_PineappleStick As Decimal = 9.5
    Const Price_Salad As Decimal = 8.6
    Const Price_Strawberry As Decimal = 4.5
    Const Price_Tea As Decimal = 5.6
    Const Price_ToastedBagel As Decimal = 7.5
    Const Price_VanillaCone As Decimal = 2.5
    Const Price_VanillaShake As Decimal = 3.6
    Const Tax_Rate As Decimal = 1.7

    Dim iTax As Decimal
    Dim iSubTotal As Decimal
    Dim iTotal As Decimal
    Dim itemcost(22) As Decimal



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit!", "Fast Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each txt In {txtCheeseSandwich, txtChikenSalad, txtChikenSandwich, txtCoffee, txtCola, txtCone, txtFishSandwich, txtFries,
           txtHamburger, txtHash, txtMilkShake, txtMuffin, txtOnionRings, txtPancakes, txtPineapple, txtSalad, txtShake, txtStrawberry,
           txtTea, txtTea, txtToasted, txtWater, txtPayementMethod}
            txt.Clear()
            txt.Text = "0"
        Next
        lblChange.Text = ""
        lblSubTotal.Text = ""
        lblTax.Text = ""
        lblTotal.Text = ""
        cmbPayementMethod.Text = ""
        txtPayementMethod.Enabled = False
        txtPayementMethod.Text = "0"

        For Each chk In {chkBottle, chkCheeseSandwich, chkChikenSalad, chkChocolateMilkShake, chkChocolateMuffin, chkCoffee,
            chkFishSandwich, chkCola, chkFries, chkHamburger, chkHashBrown, chkOnion, chkPancakes, chkSalad, chkPineapple,
            chkStrawberryShake, chkTea, chkToasted, chkVanillaCone, chkVanillaShake}
            chk.Checked = False
        Next
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each txt In {txtCheeseSandwich, txtChikenSalad, txtChikenSandwich, txtCoffee, txtCola, txtCone, txtFishSandwich, txtFries,
           txtHamburger, txtHash, txtMilkShake, txtMuffin, txtOnionRings, txtPancakes, txtPineapple, txtSalad, txtShake, txtStrawberry,
           txtTea, txtTea, txtToasted, txtWater, txtPayementMethod}
            txt.Enabled = False
        Next

        cmbPayementMethod.Items.Add("")
        cmbPayementMethod.Items.Add("Cash")
        cmbPayementMethod.Items.Add("Master Card")
        cmbPayementMethod.Items.Add("Visa Card")
        cmbPayementMethod.Items.Add("Debit Card")

    End Sub

    Private Sub chkFries_CheckedChanged(sender As Object, e As EventArgs) Handles chkFries.CheckedChanged
        If chkFries.Checked = True Then
            txtFries.Enabled = True
            txtFries.Text = ""
            txtFries.Focus()
        Else
            txtFries.Enabled = False
            txtFries.Clear()
            txtFries.Text = "0"
        End If
    End Sub

    Private Sub Numbers_Only(sender As Object, e As KeyPressEventArgs) Handles txtSalad.KeyPress, txtOnionRings.KeyPress, txtHamburger.KeyPress, txtFries.KeyPress, txtFishSandwich.KeyPress, txtChikenSandwich.KeyPress, txtChikenSalad.KeyPress, txtCheeseSandwich.KeyPress, txtToasted.KeyPress, txtPineapple.KeyPress, txtPancakes.KeyPress, txtMuffin.KeyPress, txtHash.KeyPress, txtPayementMethod.KeyPress, txtWater.KeyPress, txtTea.KeyPress, txtCola.KeyPress, txtCoffee.KeyPress, txtStrawberry.KeyPress, txtShake.KeyPress, txtMilkShake.KeyPress, txtCone.KeyPress, chkChocolateMilkShake.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub chkHamburger_CheckedChanged(sender As Object, e As EventArgs) Handles chkHamburger.CheckedChanged
        If chkHamburger.Checked = True Then
            txtHamburger.Enabled = True
            txtHamburger.Text = ""
            txtHamburger.Focus()
        Else
            txtHamburger.Enabled = False
            txtHamburger.Clear()
            txtHamburger.Text = "0"
        End If
    End Sub

    Private Sub chkCheeseSandwich_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheeseSandwich.CheckedChanged
        If chkCheeseSandwich.Checked = True Then
            txtCheeseSandwich.Enabled = True
            txtCheeseSandwich.Text = ""
            txtCheeseSandwich.Focus()
        Else
            txtCheeseSandwich.Enabled = False
            txtCheeseSandwich.Clear()
            txtCheeseSandwich.Text = "0"
        End If
    End Sub

    Private Sub chkChikenSandwich_CheckedChanged(sender As Object, e As EventArgs) Handles chkChikenSandwich.CheckedChanged
        If chkChikenSandwich.Checked = True Then
            txtChikenSandwich.Enabled = True
            txtChikenSandwich.Text = ""
            txtChikenSandwich.Focus()
        Else
            txtChikenSandwich.Enabled = False
            txtChikenSandwich.Clear()
            txtChikenSandwich.Text = "0"
        End If
    End Sub

    Private Sub chkFishSandwich_CheckedChanged(sender As Object, e As EventArgs) Handles chkFishSandwich.CheckedChanged
        If chkFishSandwich.Checked = True Then
            txtFishSandwich.Enabled = True
            txtFishSandwich.Text = ""
            txtFishSandwich.Focus()
        Else
            txtFishSandwich.Enabled = False
            txtFishSandwich.Clear()
            txtFishSandwich.Text = "0"
        End If
    End Sub

    Private Sub chkOnion_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnion.CheckedChanged
        If chkOnion.Checked = True Then
            txtOnionRings.Enabled = True
            txtOnionRings.Text = ""
            txtOnionRings.Focus()
        Else
            txtOnionRings.Enabled = False
            txtOnionRings.Clear()
            txtOnionRings.Text = "0"
        End If
    End Sub

    Private Sub chkSalad_CheckedChanged(sender As Object, e As EventArgs) Handles chkSalad.CheckedChanged
        If chkSalad.Checked = True Then
            txtSalad.Enabled = True
            txtSalad.Text = ""
            txtSalad.Focus()
        Else
            txtSalad.Enabled = False
            txtSalad.Clear()
            txtSalad.Text = "0"
        End If
    End Sub

    Private Sub chkChikenSalad_CheckedChanged(sender As Object, e As EventArgs) Handles chkChikenSalad.CheckedChanged
        If chkChikenSalad.Checked = True Then
            txtChikenSalad.Enabled = True
            txtChikenSalad.Text = ""
            txtChikenSalad.Focus()
        Else
            txtChikenSalad.Enabled = False
            txtChikenSalad.Clear()
            txtChikenSalad.Text = "0"
        End If
    End Sub

    Private Sub chkHashBrown_CheckedChanged(sender As Object, e As EventArgs) Handles chkHashBrown.CheckedChanged
        If chkHashBrown.Checked = True Then
            txtHash.Enabled = True
            txtHash.Text = ""
            txtHash.Focus()
        Else
            txtHash.Enabled = False
            txtHash.Clear()
            txtHash.Text = "0"
        End If
    End Sub

    Private Sub chkToasted_CheckedChanged(sender As Object, e As EventArgs) Handles chkToasted.CheckedChanged
        If chkToasted.Checked = True Then
            txtToasted.Enabled = True
            txtToasted.Text = ""
            txtToasted.Focus()
        Else
            txtToasted.Enabled = False
            txtToasted.Clear()
            txtToasted.Text = "0"
        End If
    End Sub

    Private Sub chkPineapple_CheckedChanged(sender As Object, e As EventArgs) Handles chkPineapple.CheckedChanged
        If chkPineapple.Checked = True Then
            txtPineapple.Enabled = True
            txtPineapple.Text = ""
            txtPineapple.Focus()
        Else
            txtPineapple.Enabled = False
            txtPineapple.Clear()
            txtPineapple.Text = "0"
        End If
    End Sub

    Private Sub chkChocolateMuffin_CheckedChanged(sender As Object, e As EventArgs) Handles chkChocolateMuffin.CheckedChanged
        If chkChocolateMuffin.Checked = True Then
            txtMuffin.Enabled = True
            txtMuffin.Text = ""
            txtMuffin.Focus()
        Else
            txtMuffin.Enabled = False
            txtMuffin.Clear()
            txtMuffin.Text = "0"
        End If
    End Sub

    Private Sub chkPancakes_CheckedChanged(sender As Object, e As EventArgs) Handles chkPancakes.CheckedChanged
        If chkPancakes.Checked = True Then
            txtPancakes.Enabled = True
            txtPancakes.Text = ""
            txtPancakes.Focus()
        Else
            txtPancakes.Enabled = False
            txtPancakes.Clear()
            txtPancakes.Text = "0"
        End If
    End Sub

    Private Sub chkTea_CheckedChanged(sender As Object, e As EventArgs) Handles chkTea.CheckedChanged
        If chkTea.Checked = True Then
            txtTea.Enabled = True
            txtTea.Text = ""
            txtTea.Focus()
        Else
            txtTea.Enabled = False
            txtTea.Clear()
            txtTea.Text = "0"
        End If
    End Sub

    Private Sub chkCoffee_CheckedChanged(sender As Object, e As EventArgs) Handles chkCoffee.CheckedChanged
        If chkCoffee.Checked = True Then
            txtCoffee.Enabled = True
            txtCoffee.Text = ""
            txtCoffee.Focus()
        Else
            txtCoffee.Enabled = False
            txtCoffee.Clear()
            txtCoffee.Text = "0"
        End If
    End Sub

    Private Sub chkCola_CheckedChanged(sender As Object, e As EventArgs) Handles chkCola.CheckedChanged
        If chkCola.Checked = True Then
            txtCola.Enabled = True
            txtCola.Text = ""
            txtCola.Focus()
        Else
            txtCola.Enabled = False
            txtCola.Clear()
            txtCola.Text = "0"
        End If
    End Sub

    Private Sub chkBottle_CheckedChanged(sender As Object, e As EventArgs) Handles chkBottle.CheckedChanged
        If chkBottle.Checked = True Then
            txtWater.Enabled = True
            txtWater.Text = ""
            txtWater.Focus()
        Else
            txtWater.Enabled = False
            txtWater.Clear()
            txtWater.Text = "0"
        End If
    End Sub

    Private Sub chkVanillaCone_CheckedChanged(sender As Object, e As EventArgs) Handles chkVanillaCone.CheckedChanged
        If chkVanillaCone.Checked = True Then
            txtCone.Enabled = True
            txtCone.Text = ""
            txtCone.Focus()
        Else
            txtCone.Enabled = False
            txtCone.Clear()
            txtCone.Text = "0"
        End If
    End Sub

    Private Sub chkVanillaShake_CheckedChanged(sender As Object, e As EventArgs) Handles chkVanillaShake.CheckedChanged
        If chkVanillaShake.Checked = True Then
            txtShake.Enabled = True
            txtShake.Text = ""
            txtShake.Focus()
        Else
            txtShake.Enabled = False
            txtShake.Clear()
            txtShake.Text = "0"
        End If
    End Sub

    Private Sub chkStrawberryShake_CheckedChanged(sender As Object, e As EventArgs) Handles chkStrawberryShake.CheckedChanged
        If chkStrawberryShake.Checked = True Then
            txtStrawberry.Enabled = True
            txtStrawberry.Text = ""
            txtStrawberry.Focus()
        Else
            txtStrawberry.Enabled = False
            txtStrawberry.Clear()
            txtStrawberry.Text = "0"
        End If
    End Sub

    Private Sub chkChocolateMilkShake_CheckedChanged(sender As Object, e As EventArgs) Handles chkChocolateMilkShake.CheckedChanged
        If chkChocolateMilkShake.Checked = True Then
            txtMilkShake.Enabled = True
            txtMilkShake.Text = ""
            txtMilkShake.Focus()
        Else
            txtMilkShake.Enabled = False
            txtMilkShake.Clear()
            txtMilkShake.Text = "0"
        End If
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        itemcost(0) = Convert.ToDecimal(txtFries.Text) * Price_Fries
        itemcost(1) = Convert.ToDecimal(txtHamburger.Text) * Price_Hamburger
        itemcost(2) = Convert.ToDecimal(txtCheeseSandwich.Text) * Price_cheeseSandwich
        itemcost(3) = Convert.ToDecimal(txtChikenSandwich.Text) * Price_ChikenSandwich
        itemcost(4) = Convert.ToDecimal(txtFishSandwich.Text) * Price_FishSandwich
        itemcost(5) = Convert.ToDecimal(txtOnionRings.Text) * Price_OnionRings
        itemcost(6) = Convert.ToDecimal(txtSalad.Text) * Price_Salad
        itemcost(7) = Convert.ToDecimal(txtFries.Text) * Price_Fries
        itemcost(8) = Convert.ToDecimal(txtChikenSalad.Text) * Price_ChikenSalad
        itemcost(9) = Convert.ToDecimal(txtHash.Text) * Price_HashBrown
        itemcost(10) = Convert.ToDecimal(txtToasted.Text) * Price_ToastedBagel
        itemcost(11) = Convert.ToDecimal(txtPineapple.Text) * Price_PineappleStick
        itemcost(12) = Convert.ToDecimal(txtMuffin.Text) * Price_ChocolateMuffin
        itemcost(13) = Convert.ToDecimal(txtPancakes.Text) * Price_Pancakes
        itemcost(14) = Convert.ToDecimal(txtTea.Text) * Price_Tea
        itemcost(15) = Convert.ToDecimal(txtCoffee.Text) * Price_Coffee
        itemcost(16) = Convert.ToDecimal(txtCola.Text) * Price_Cola
        itemcost(17) = Convert.ToDecimal(txtWater.Text) * Price_BottleWater
        itemcost(18) = Convert.ToDecimal(txtCone.Text) * Price_VanillaCone
        itemcost(19) = Convert.ToDecimal(txtShake.Text) * Price_VanillaShake
        itemcost(20) = Convert.ToDecimal(txtStrawberry.Text) * Price_Strawberry
        itemcost(21) = Convert.ToDecimal(txtMilkShake.Text) * Price_ChocolateMilkShake


        Dim Cost As Decimal
        If cmbPayementMethod.Text = "Cash" Then
            iSubTotal = itemcost(0) + itemcost(1) + itemcost(2) + itemcost(3) + itemcost(4) + itemcost(5) + itemcost(6) +
            itemcost(7) + itemcost(8) + itemcost(9) + itemcost(10) + itemcost(11) + itemcost(12) + itemcost(13) + itemcost(14) +
            itemcost(15) + itemcost(16) + itemcost(17) + itemcost(18) + itemcost(19) + itemcost(20) + itemcost(21)
            Cost = txtPayementMethod.Text - iSubTotal
            lblChange.Text = Cost
            lblSubTotal.Text = iSubTotal
            iTax = (iSubTotal * Tax_Rate) / 100
            lblTax.Text = iTax
            lblTotal.Text = iTax + iSubTotal

        ElseIf cmbPayementMethod.Text = "Master Card" Or cmbPayementMethod.Text = "Visa Card" Or cmbPayementMethod.Text = "Debit Card" Then
            iSubTotal = itemcost(0) + itemcost(1) + itemcost(2) + itemcost(3) + itemcost(4) + itemcost(5) + itemcost(6) +
            itemcost(7) + itemcost(8) + itemcost(9) + itemcost(10) + itemcost(11) + itemcost(12) + itemcost(13) + itemcost(14) +
            itemcost(15) + itemcost(16) + itemcost(17) + itemcost(18) + itemcost(19) + itemcost(20) + itemcost(21)
            Cost = txtPayementMethod.Text - iSubTotal
            lblSubTotal.Text = iSubTotal
            iTax = (iSubTotal * Tax_Rate) / 100
            lblTax.Text = iTax
            lblTotal.Text = iTax + iSubTotal
        Else
            MessageBox.Show("You Must Select A Payement Method", "Fast Food ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        lblChange.Text = FormatCurrency(lblChange.Text)
        lblSubTotal.Text = FormatCurrency(lblSubTotal.Text)
        lblTax.Text = FormatCurrency(lblTax.Text)
        lblTotal.Text = FormatCurrency(lblTotal.Text)
    End Sub

    Private Sub cmbPayementMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPayementMethod.SelectedIndexChanged
        If cmbPayementMethod.Text = "Cash" Then
            txtPayementMethod.Enabled = True
            txtPayementMethod.Text = ""
            txtPayementMethod.Focus()
        Else
            txtPayementMethod.Enabled = False
            txtPayementMethod.Text = "0"

        End If
    End Sub
End Class