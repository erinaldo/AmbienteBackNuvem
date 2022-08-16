Module mdl_limpacampostextbox
    Public Sub limparTextBoxes(ByVal controles As Control)
        For Each ctrl As Control In controles.Controls

            If TypeOf ctrl Is TextBox Then

                CType(ctrl, TextBox).Text = String.Empty
            ElseIf TypeOf ctrl Is NumericUpDown Then
                CType(ctrl, NumericUpDown).Value = 0
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                CType(ctrl, MaskedTextBox).Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Text = ""
            ElseIf ctrl.Controls.Count > 0 Then
                limparTextBoxes(ctrl)
            End If
        Next
    End Sub
End Module
