﻿Namespace LanguageExtensions
    Public Module DataGridViewExtensions
        <Runtime.CompilerServices.Extension>
        Public Sub ExpandColumns(sender As DataGridView)
            For Each col As DataGridViewColumn In sender.Columns
                ' ensure we are not attempting to do this on a Entity
                If col.ValueType IsNot Nothing AndAlso col.ValueType.Name <> "ICollection`1" Then
                    col.HeaderText = col.HeaderText.SplitCamelCase
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End If
            Next
        End Sub
    End Module
End Namespace