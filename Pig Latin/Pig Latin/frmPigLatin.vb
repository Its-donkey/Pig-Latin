Imports System.Text

Public Class frmPigLatin
    Private Sub btnClearInputText_Click(sender As Object, e As EventArgs) Handles btnClearInputText.Click
        txtWordInput.Clear()
        txtConversionOutput.Clear()
    End Sub

    Private Sub btnConvertText_Click(sender As Object, e As EventArgs) Handles btnConvertText.Click
        Dim input As String = txtWordInput.Text

        If String.IsNullOrEmpty(input) Then
            MsgBox("No valid text has been entered to translate")
            Exit Sub
        Else
            'Split text into array
            Dim words() As String = input.Split(CType(" ", Char()))
            Dim firstCharacter As String
            Dim outputText As New StringBuilder

            For i As Integer = 0 To words.GetUpperBound(0)

                firstCharacter = words(i).First

                If words(i).Length > 2 Then

                    Dim wordCharacters() = words(i).ToCharArray()

                    For Each s In "@#$%^&*1234567890".ToCharArray
                        For Each wc In words(i).ToCharArray()
                            If s = wc Then
                                GoTo AppendText
                            End If
                        Next
                    Next

                    Select Case firstCharacter

                        Case "a", "e", "i", "o", "u",
                             "A", "E", "I", "O", "U"

                            Dim punctuationMark As String = words(i).Last
                            Dim attachedPunctuation As String = Nothing

                            For Each p In "':,—!-().?"";".ToCharArray()
                                If punctuationMark = p Then
                                    words(i) = words(i).Remove(words(i).Length - 1)
                                    attachedPunctuation = p
                                End If
                            Next

                            words(i) = words(i) & "way" & attachedPunctuation

                        Case "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z",
                            "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z"
                            Dim vowelFirstIndex As Integer = 999

                            For Each c In "aeiouy".ToCharArray()
                                If words(i).IndexOf(c) <> -1 And words(i).IndexOf(c) < vowelFirstIndex Then
                                    vowelFirstIndex = words(i).IndexOf(c)
                                End If
                            Next

                            Dim charactersToMove As String = words(i).Substring(0, vowelFirstIndex)

                            Dim punctuationMark As String = words(i).Last
                            Dim attachedPunctuation As String = Nothing

                            For Each p In "':,—!-().?"";".ToCharArray()
                                If punctuationMark = p Then
                                    words(i) = words(i).Remove(words(i).Length - 1)
                                    attachedPunctuation = p
                                End If
                            Next

                            words(i) = words(i).Remove(0, vowelFirstIndex) & charactersToMove & "ay" & If(attachedPunctuation IsNot Nothing, attachedPunctuation, "")
                    End Select

                End If
AppendText:
                outputText.Append(words(i) & " ")
            Next

            txtConversionOutput.Text = outputText.ToString
        End If
    End Sub

    Function getVowels() As String

    End Function

    Private Sub txtWordInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtWordInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class
