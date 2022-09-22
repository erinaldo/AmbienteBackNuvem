Module mdl_bloquearcampos
    Public funcao As String
    Public Sub bloquearcampos(ByVal controles As Control)
        For Each ctrl As Control In controles.Controls
            If (funcao = "LIBERAR") Then
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Enabled = True
                ElseIf TypeOf ctrl Is NumericUpDown Then
                    CType(ctrl, NumericUpDown).Enabled = True
                ElseIf TypeOf ctrl Is MaskedTextBox Then
                    CType(ctrl, MaskedTextBox).Enabled = True
                ElseIf TypeOf ctrl Is ComboBox Then
                    CType(ctrl, ComboBox).Enabled = True
                ElseIf TypeOf ctrl Is Button Then
                    CType(ctrl, Button).Enabled = True
                ElseIf TypeOf ctrl Is DateTimePicker Then
                    CType(ctrl, DateTimePicker).Enabled = True
                ElseIf TypeOf ctrl Is RichTextBox Then
                    CType(ctrl, RichTextBox).Enabled = True
                ElseIf ctrl.Controls.Count > 0 Then
                    bloquearcampos(ctrl)
                End If
            ElseIf (funcao = "BLOQUEAR") Then
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Enabled = False
                ElseIf TypeOf ctrl Is NumericUpDown Then
                    CType(ctrl, NumericUpDown).Enabled = False
                ElseIf TypeOf ctrl Is MaskedTextBox Then
                    CType(ctrl, MaskedTextBox).Enabled = False
                ElseIf TypeOf ctrl Is ComboBox Then
                    CType(ctrl, ComboBox).Enabled = False
                ElseIf TypeOf ctrl Is Button Then
                    CType(ctrl, Button).Enabled = False
                ElseIf TypeOf ctrl Is DateTimePicker Then
                    CType(ctrl, DateTimePicker).Enabled = False
                ElseIf TypeOf ctrl Is RichTextBox Then
                    CType(ctrl, RichTextBox).Enabled = False
                ElseIf ctrl.Controls.Count > 0 Then
                    bloquearcampos(ctrl)
                End If
            End If


        Next
    End Sub
End Module
